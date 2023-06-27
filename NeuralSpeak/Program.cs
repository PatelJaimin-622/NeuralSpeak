using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using Azure;
using Azure.AI.Translation.Text;
using System.Text;

class Program
{
    // This example requires environment variables named "SPEECH_KEY" and "SPEECH_REGION"
    static string speechKey = "862c2f7c4eaf4ef4aeb8229d7b971fc4";
    static string speechRegion = "eastasia";
    static string voiceKey = "a6cf9b866ee640cca1e58c23c138a702";


    static async Task OutputSpeechRecognitionResult(SpeechRecognitionResult speechRecognitionResult)
    {
        switch (speechRecognitionResult.Reason)
        {
            case ResultReason.RecognizedSpeech:
                await Translatevoice(speechRecognitionResult.Text);
                Console.WriteLine($"RECOGNIZED: Text={speechRecognitionResult.Text}");
                break;
            case ResultReason.NoMatch:
                Console.WriteLine($"NOMATCH: Speech could not be recognized.");
                break;
            case ResultReason.Canceled:
                var cancellation = CancellationDetails.FromResult(speechRecognitionResult);
                Console.WriteLine($"CANCELED: Reason={cancellation.Reason}");

                if (cancellation.Reason == CancellationReason.Error)
                {
                    Console.WriteLine($"CANCELED: ErrorCode={cancellation.ErrorCode}");
                    Console.WriteLine($"CANCELED: ErrorDetails={cancellation.ErrorDetails}");
                    Console.WriteLine($"CANCELED: Did you set the speech resource key and region values?");
                }
                break;
        }
    }

    static async Task Translatevoice(string currnetSentence)
    {
        string key = "6920569d33f347f1965e48932922d76b";
        string region = "eastasia";

        AzureKeyCredential credential = new(key);
        TextTranslationClient client = new(credential, region);

        try
        {
            string targetLanguage = "hi";
            string inputText = currnetSentence;

            Response<IReadOnlyList<TranslatedTextItem>> response = await client.TranslateAsync(targetLanguage, inputText).ConfigureAwait(false);
            IReadOnlyList<TranslatedTextItem> translations = response.Value;
            TranslatedTextItem translation = translations.FirstOrDefault();

            Console.WriteLine($"Detected languages of the input text: {translation?.DetectedLanguage?.Language} with score: {translation?.DetectedLanguage?.Score}.");
            Console.WriteLine($"Text was translated to: '{translation?.Translations?.FirstOrDefault().To}' and the result is: '{translation?.Translations?.FirstOrDefault()?.Text}'.");
            //==========Text to voice=============

            // The language of the voice that speaks.
            var speechConfig = SpeechConfig.FromSubscription(voiceKey, speechRegion);
            speechConfig.SpeechSynthesisVoiceName = "hi-IN-MadhurNeural";
            //speechConfig.SpeechSynthesisVoiceName = "en-US-JennyNeural";
            using (var speechSynthesizer = new SpeechSynthesizer(speechConfig))
            {
                // Get text from the console and synthesize to the default speaker.
                string text = translation?.Translations?.FirstOrDefault()?.Text;
                var speechSynthesisResult = await speechSynthesizer.SpeakTextAsync(text);
                OutputSpeechSynthesisResult(speechSynthesisResult, text);
            }

            //=======================
        }
        catch (RequestFailedException exception)
        {
            Console.WriteLine($"Error Code: {exception.ErrorCode}");
            Console.WriteLine($"Message: {exception.Message}");
        }
    }


    static void OutputSpeechSynthesisResult(SpeechSynthesisResult speechSynthesisResult, string text)
    {
        switch (speechSynthesisResult.Reason)
        {
            case ResultReason.SynthesizingAudioCompleted:
                Console.WriteLine($"Speech synthesized for text: [{text}]");
                break;
            case ResultReason.Canceled:
                var cancellation = SpeechSynthesisCancellationDetails.FromResult(speechSynthesisResult);
                Console.WriteLine($"CANCELED: Reason={cancellation.Reason}");

                if (cancellation.Reason == CancellationReason.Error)
                {
                    Console.WriteLine($"CANCELED: ErrorCode={cancellation.ErrorCode}");
                    Console.WriteLine($"CANCELED: ErrorDetails=[{cancellation.ErrorDetails}]");
                    Console.WriteLine($"CANCELED: Did you set the speech resource key and region values?");
                }
                break;
            default:
                break;
        }
    }

    async static Task Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        var speechConfig = SpeechConfig.FromSubscription(speechKey, speechRegion);
        speechConfig.SpeechRecognitionLanguage = "en-US";

        using var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
        using var speechRecognizer = new SpeechRecognizer(speechConfig, audioConfig);


        //=================Continuous===================================
        //using var speechRecognizer = new SpeechRecognizer(speechConfig, audioConfig);

        //var stopRecognition = new TaskCompletionSource<int>();
        //speechRecognizer.Recognizing += (s, e) =>
        //{
        //    var t1 = "";
        //    t1 = t1 + e.Result.Text;
        //    Console.Write("\r {0}",t1);
        //    //Console.WriteLine($"RECOGNIZING: Text={e.Result.Text}");
        //    //Console.Clear();
        //    Translatevoice(t1);
        //};

        //speechRecognizer.Recognized += (s, e) =>
        //{
        //    if (e.Result.Reason == ResultReason.RecognizedSpeech)
        //    {
        //        Console.WriteLine($"RECOGNIZED: Text={e.Result.Text}");
        //    }
        //    else if (e.Result.Reason == ResultReason.NoMatch)
        //    {
        //        Console.WriteLine($"NOMATCH: Speech could not be recognized.");
        //    }
        //};

        //speechRecognizer.Canceled += (s, e) =>
        //{
        //    Console.WriteLine($"CANCELED: Reason={e.Reason}");

        //    if (e.Reason == CancellationReason.Error)
        //    {
        //        Console.WriteLine($"CANCELED: ErrorCode={e.ErrorCode}");
        //        Console.WriteLine($"CANCELED: ErrorDetails={e.ErrorDetails}");
        //        Console.WriteLine($"CANCELED: Did you set the speech resource key and region values?");
        //    }

        //    stopRecognition.TrySetResult(0);
        //};

        //speechRecognizer.SessionStopped += (s, e) =>
        //{
        //    Console.WriteLine("\n    Session stopped event.");
        //    stopRecognition.TrySetResult(0);
        //};

        //====================================================

        Console.WriteLine("Speak into your microphone.");
        var speechRecognitionResult = await speechRecognizer.RecognizeOnceAsync();
        await OutputSpeechRecognitionResult(speechRecognitionResult);

        //====================Continuous========================
        //await speechRecognizer.StartContinuousRecognitionAsync();
        //Task.WaitAny(new[] { stopRecognition.Task });
        //============================================


    }
}