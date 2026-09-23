using System.Text.Json;
 
HttpClient clienteHttp = new();
 
string url = "https://api.disneyapi.dev/character/423";
 
string respostaJson = await clienteHttp.GetStringAsync(url);
 
DisneyResponse? personagemRecebido =
JsonSerializer.Deserialize<DisneyResponse>(
respostaJson,
new JsonSerializerOptions
{
PropertyNameCaseInsensitive = true
});
 
if (personagemRecebido?.Data != null)
{
Console.WriteLine($"Nome: {personagemRecebido.Data.Name}");
Console.WriteLine($"Imagem: {personagemRecebido.Data.ImageUrl}");
}