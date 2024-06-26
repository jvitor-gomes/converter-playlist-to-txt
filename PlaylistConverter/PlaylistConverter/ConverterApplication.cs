using System;

namespace PlaylistConverter
{
    class ConverterApplication
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: PlaylistConverter.exe <input_playlist_path> <output_text_path>");
                return;
            }

            string inputPlaylistPath = args[0];
            string outputTextPath = args[1];

            try
            {
                var converter = new Converters.XmlPlaylistConverter();
                converter.ConvertPlaylistToText(inputPlaylistPath, outputTextPath);
                Console.WriteLine("File converted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
