public async Task<int> RetrieveDocsHomePage()
{
    var client = new HttpsClient();
    byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/en-us/");

    Console.WriteLine($"{nameof(RetrieveDocsHomePage)}: finished downlaoding.");
    return content.Length;
}