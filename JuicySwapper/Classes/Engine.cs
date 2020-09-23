using JuicySwapper.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuicySwapper.IO
{
    public class Engine
    {

        public static bool Convert(long start, string file, string convert, string revert, long max = 0, long additional = 0, bool minus = false, bool messages = false)
        {
            byte[] a = Encoding.UTF8.GetBytes(convert);
            byte[] b = Encoding.UTF8.GetBytes(revert);
            if ((convert.Length - revert.Length) >= 0)
            {
                for (int i = 0; i < convert.Length - revert.Length; i++)
                {
                    b = c(b, 0);
                }

                if (File.Exists(file))
                {
                    Stream s = File.Open(file, FileMode.Open, FileAccess.ReadWrite);

                    long offset;

                    var task = Task.Run(() => d(s, start, a, max));
                    if (task.Wait(TimeSpan.FromSeconds(10)))
                    {
                        offset = task.Result;
                        Settings.Default.current_offset = offset;
                        Settings.Default.Save();
                    }
                    else
                        offset = 0;

                    s.Close();

                    if (offset == 0)
                    {
                        if (messages)
                        {
                            MessageBox.Show("Already converted, or string not found in pak! (Ask for help on discord!)", "- whey", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return false;
                    }

                    if (additional != 0 && minus)
                    {
                        offset -= additional;
                    }
                    else if (additional != 0 && !minus)
                    {
                        offset += additional;
                    }

                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(file, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(b);
                    binaryWriter.Close();

                    if (messages)
                    {
                        MessageBox.Show("Successfully converted!");
                    }

                    return true;
                }
                else
                {
                    if (messages)
                    {
                        MessageBox.Show("The pak file specified doesn't exist");
                    }
                    return false;
                }
            }
            else
            {
                if (messages)
                {
                    MessageBox.Show("Convert string is lower than revert string");
                }
                return false;
            }
        }

        public static bool Revert(long start, string file, string convert, string revert, long max = 0, long additional = 0, bool messages = true, bool v = false)
        {
            byte[] a = Encoding.UTF8.GetBytes(convert);
            byte[] b = Encoding.UTF8.GetBytes(revert);
            if ((convert.Length - revert.Length) >= 0)
            {
                for (int i = 0; i < convert.Length - revert.Length; i++)
                {
                    b = c(b, 0);
                }

                if (File.Exists(file))
                {
                    Stream s = File.Open(file, FileMode.Open, FileAccess.ReadWrite);

                    long offset;

                    var task = Task.Run(() => d(s, start, b, max));
                    if (task.Wait(TimeSpan.FromSeconds(10)))
                    {
                        offset = task.Result;
                        Settings.Default.current_offset = offset;
                        Settings.Default.Save();
                    }
                    else
                        offset = 0;

                    s.Close();

                    if (offset == 0)
                    {
                        if (messages)
                        {
                            MessageBox.Show("Already converted, or string not found in pak!");
                        }
                        return false;
                    }

                    if (additional != 0)
                    {
                        offset += additional;
                    }

                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(file, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(a);
                    binaryWriter.Close();

                    if (messages)
                    {
                        MessageBox.Show("Successfully reverted!");
                    }

                    return true;
                }
                else
                {
                    if (messages)
                    {
                        MessageBox.Show("The pak file specified doesn't exist");
                    }
                    return false;
                }
            }
            else
            {
                if (messages)
                {
                    MessageBox.Show("Revert string is lower than Convert string");
                }
                return false;
            }
        }


        private static byte[] c(byte[] mahOldByteArray, byte newByte)
        {
            var mahByteArray = new List<byte>();
            mahByteArray.AddRange(mahOldByteArray);
            mahByteArray.Add(newByte);
            return mahByteArray.ToArray();
        }

        private static long d(Stream a, long b, byte[] c, long max)
        {
            int searchPosition = 0;
            long result = 0;
            a.Position = b;
            bool max1 = false;

            if (max == 0)
            {
                max1 = false;
            }
            else if (max > 1)
            {
                max1 = true;
            }

            while (true)
            {
                if (max1)
                {
                    if (a.Position == max)
                    {
                        return result;
                    }

                }
                else
                {
                    if (a.Position == 5000000000)
                    {
                        return result;
                    }
                }

                var latestbyte = a.ReadByte();
                if (latestbyte == -1)
                {
                    break;
                }

                if (latestbyte == c[searchPosition])
                {
                    searchPosition++;
                    if (searchPosition == c.Length)
                    {
                        result = a.Position - c.Length;
                        return result;
                    }
                }
                else
                {
                    searchPosition = 0;
                }
            }

            return result;
        }
    }
}
