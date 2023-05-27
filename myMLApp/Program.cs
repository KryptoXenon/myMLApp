using MyMLApp;

var sampleData = new SentimentModel.ModelInput()
{
    Col0 = "The crust is not good"
};

var result = SentimentModel.Predict(sampleData);

var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";

Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");