using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace JSRF_Character_Renamer
{
    class Renamer
    {

        public static bool checkXbeModded(string file)
        {
            Process process = new Process();

            process.StartInfo.FileName = "section.exe";
            process.StartInfo.Arguments = $"\"{file}\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();

            var output = process.StandardOutput.ReadToEnd();

            if (output.Contains(".prt") && output.Contains(".prd") && output.Contains(".pd"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void changePlayerName(int address, string newName, int dataLocationRaw, int dataLocationVir, string file)
        {

            if (newName.Length < readName(dataLocationRaw, file, 100).Length)
            {
                byte[] nullBytes = { };
                for (int i = 0; i < 99; i++)
                {
                    nullBytes = addByte(nullBytes, 00); // 99 null bytes
                }
                using (BinaryWriter writer = new BinaryWriter(new FileStream(file, FileMode.Open)))
                {
                    writer.BaseStream.Position = dataLocationRaw; // goto offset
                    writer.Write(nullBytes, 0, nullBytes.Length); // write null bytes
                    writer.Close(); // close fs
                }
            }

            byte[] name = Encoding.ASCII.GetBytes(newName);

            using (BinaryWriter writer = new BinaryWriter(new FileStream(file, FileMode.Open)))
            {
                writer.BaseStream.Position = dataLocationRaw;
                writer.Write(name, 0, name.Length);

                writer.BaseStream.Position = address;
                writer.Write(dataLocationVir);

                #if DEBUG
                    MessageBox.Show($"DEBUG:\n\nName address: {address}\nRaw Data location: {dataLocationRaw}\nVirtual Data location: {dataLocationVir}");
                # else
                    MessageBox.Show($"Changed name to: {newName}", "JSRF Renamer");
                #endif
            }
        }

        public static bool addSections(string source, string dest)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "/section.exe"))
            {
                Process process = new Process();

                process.StartInfo.FileName = "section.exe";
                process.StartInfo.Arguments = $"\"{source}\" \"{dest}\"";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.WaitForExit();

                return true;
            }
            else
            {
                return false;
            }
        }

        public static string readName(int offset, string file, int length)
        {
            using (BinaryReader reader = new BinaryReader(new FileStream(file, FileMode.Open)))
            {
                reader.BaseStream.Position = offset;
                var address = Encoding.UTF8.GetString(reader.ReadBytes(length));
                return address;
            }
        }

        public static byte[] addByte(byte[] bArray, byte newByte)
        {
            byte[] newArray = new byte[bArray.Length + 1];
            bArray.CopyTo(newArray, 1);
            newArray[0] = newByte;
            return newArray;
        }
    }
}
