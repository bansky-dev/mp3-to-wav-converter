using NAudio.Wave; 

namespace mp3_to_wav_converter;

class Program
{
    static string inputMp3File;
    static string outputWavFile;

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Please specify the input mp3 audio (full path): ");
            inputMp3File = Console.ReadLine();

            Console.Write("Please speciy the output wav audio (full path): ");
            outputWavFile = Console.ReadLine();
        }
        catch(Exception ex)
        {
            System.Console.WriteLine($"ERROR CAUGHT: {ex}");
        }

        try
        {
            using(var reader = new Mp3FileReader(inputMp3File))
            {
                WaveFileWriter.CreateWaveFile(outputWavFile, reader);
                System.Console.WriteLine("Succes!");
            }

        }
        catch(Exception ex)
        {
            System.Console.WriteLine(ex);
        }
        

        //TODO: Improve error handling, and experience with using the app
    



    }
}
