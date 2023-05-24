using MyMLApp;

var sampleData = new SentimentModel.ModelInput()
{
    Col0 = "Bad food"
};

var result = SentimentModel.Predict(sampleData);

var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";

Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");