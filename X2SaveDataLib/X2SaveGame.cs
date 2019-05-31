using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace X2SaveDataLib {
	public enum X2SaveVersion : UInt32 {
		Unknown = 0,
		XCom2 = 0x14,
		XCom2WotC = 0x15,
		XCom2WotC_TLP = 0x16,
	}

	public class X2SaveGame {
		/// <summary>
		/// Specifies the default encoding that is used internally to decode strings.
		/// </summary>
		public static Encoding DefaultEncoder = Encoding.GetEncoding("iso-8859-1");

		public X2SaveVersion Version { get; private set; }
		public uint CampaignNumber { get; private set; }
		public uint SaveGameNumber { get; private set; }
		public string Description { get; private set; }
		public string MapCommand { get; private set; }
		public string Language { get; private set; }		
		public DateTime? Created { get; private set; }
		public DateTime? LastModified { get; private set; }
		public string UILib { get; private set; }
		public string Name { get; private set; }

		/// <summary>
		/// Unknown. Seems to change with each save.
		/// </summary>
		public uint Unknown1 { get; private set; }

		/// <summary>
		/// Unknown. Potentially a checksum.
		/// </summary>
		public uint Unknown2 { get; private set; }

		/// <summary>
		/// Unknown. Seems to be always 0.
		/// </summary>
		public uint Unknown3 { get; private set; }

		private List<X2SaveModData> _Mods;
		public ReadOnlyCollection<X2SaveModData> Mods {
			get { return new ReadOnlyCollection<X2SaveModData>(_Mods); }
		}

		public X2SaveGame() {
			Version = X2SaveVersion.Unknown;
			CampaignNumber = 0;
			SaveGameNumber = 0;
			Description = "";
			MapCommand = "";		
			Language = "";
			Created = null;
			LastModified = null;
			UILib = "";
			Unknown1 = 0;
			Unknown2 = 0;
			Unknown3 = 0;
			Name = "";
			_Mods = new List<X2SaveModData>();
		}

		/// <summary>
		/// Parses the given data as a string, that is assumed to be prefixed with a Int32 length field.
		/// </summary>
		/// <param name="data">Savegame data. The bytes that have been processed will be removed from the list.</param>
		/// <returns>The string without the trailing \0 from the save file.</returns>
		private static string ParseX2String(List<byte> data) {
			Encoding encoder = DefaultEncoder;
			var strLength = ParseInt32(data);

			if (strLength < 0) {
				encoder = Encoding.Unicode;
				strLength = -2 * strLength;
			}

			var strData = ParseRange(data, strLength);
			
			var str = encoder.GetString(strData.ToArray());
			return str.TrimEnd('\0');
		}

		/// <summary>
		/// Interprets the first 4-Bytes of the given data as a XCOM2 game version.
		/// </summary>
		/// <param name="data">Savegame data. The bytes that have been processed will be removed from the list.</param>
		/// <returns>Game version if known, otherwise X2SaveVersion.Unknown.</returns>
		private static X2SaveVersion ParseX2Version(List<byte> data) {
			var version = ParseUInt32(data);

			if (Enum.IsDefined(typeof(X2SaveVersion), version)) {
				return (X2SaveVersion)version;
			}

			return X2SaveVersion.Unknown;
		}

		/// <summary>
		/// Return the specified number of bytes.
		/// </summary>
		/// <param name="data">Savegame data. The bytes that have been processed will be removed from the list.</param>
		/// <param name="count">Number of bytes to be returned.</param>
		/// <returns>The resulting list of bytes.</returns>
		private static List<byte> ParseRange(List<byte> list, int count) {
			var result = list.GetRange(0, count);
			list.RemoveRange(0, count);
			return result;
		}

		/// <summary>
		/// Interprets the first 4-Bytes of the given data as a little endian encoded 4-byte unsigned integer.
		/// </summary>
		/// <param name="data">Savegame data. The bytes that have been processed will be removed from the list.</param>
		/// <returns>The value.</returns>
		private static uint ParseUInt32(List<byte> data) {
			var bytes = ParseRange(data, sizeof(uint));

			// XCOM2 uses little endian
			if (!BitConverter.IsLittleEndian)
				bytes.Reverse();
			
			return BitConverter.ToUInt32(bytes.ToArray(), 0);
		}

		/// <summary>
		/// Interprets the first 4-Bytes of the given data as a little endian encoded 4-byte signed integer.
		/// </summary>
		/// <param name="data">Savegame data. The bytes that have been processed will be removed from the list.</param>
		/// <returns>The value.</returns>
		private static int ParseInt32(List<byte> data) {
			var bytes = ParseRange(data, sizeof(int));

			// XCOM2 uses little endian
			if (!BitConverter.IsLittleEndian)
				bytes.Reverse();

			return BitConverter.ToInt32(bytes.ToArray(), 0);
		}

		public static bool TryParse(List<byte> data, out X2SaveGame saveGame) {
			saveGame = null;

			try {
				saveGame = Parse(data);
				return true;
			} catch (Exception ex) {
				Debug.WriteLine(ex.Message);
			}

			return false;
		}

		public static bool TryParse(string fileName, out X2SaveGame saveGame) {
			saveGame = null;

			try {
				saveGame = Parse(fileName);
				return true;
			} catch (Exception ex) {
				Debug.WriteLine(ex.Message);
			}

			return false;
		}

		public static X2SaveGame Parse(string fileName) {
			if (!File.Exists(fileName)) {
				throw new FileNotFoundException("", fileName);
			}

			var data = File.ReadAllBytes(fileName).ToList();
			return Parse(data);
		}

		public static X2SaveGame Parse(List<byte> data) {
			var encoder = Encoding.GetEncoding("iso-8859-1");

			X2SaveGame saveGame = new X2SaveGame();
			saveGame.Version = ParseX2Version(data);
			saveGame.Unknown1 = ParseUInt32(data);
			saveGame.Unknown2 = ParseUInt32(data);
			saveGame.Unknown3 = ParseUInt32(data);
			saveGame.CampaignNumber = ParseUInt32(data);
			saveGame.SaveGameNumber = ParseUInt32(data);
			saveGame.Description = ParseX2String(data);

			string strLastModified = ParseX2String(data).Replace("\n", "");
			DateTime.TryParseExact(strLastModified, "M/d/yyyyHH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime lastModified);
			saveGame.LastModified = lastModified;

			saveGame.MapCommand = ParseX2String(data);
			var unknown2 = ParseRange(data, 16);
			saveGame.Language = ParseX2String(data);
			var unknown3 = ParseRange(data, 16);

			string strCreated = ParseX2String(data);
			DateTime.TryParseExact(strCreated, "yyyy.MM.dd-HH.mm.ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime created);
			saveGame.Created = created;

			saveGame.UILib = ParseX2String(data);
			saveGame.Name = ParseX2String(data);

			var modCount = ParseUInt32(data);
			var modNames1 = new List<string>();

			for (int i = 0; i < modCount; i++) {
				modNames1.Add(ParseX2String(data));
			}

			var modCount2 = ParseUInt32(data);
			var modNames2 = new List<string>();

			for (int i = 0; i < modCount; i++) {
				modNames2.Add(ParseX2String(data));
			}

			if (modCount != modCount2) {
				Debug.Assert(modCount == modCount2, "We expect that the two mod lists have the same length and each entries index corresponds the same mod.");
				throw new FormatException("Unexpected mod list length.");
			}		

			for (int i = 0; i < modNames1.Count; i++) {
				saveGame._Mods.Add(new X2SaveModData(i, modNames1[i], modNames2[i]));
			}

			return saveGame;
		}
    }
}
