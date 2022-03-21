using System;

namespace internet_programming_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car();
            //myCar.ShowInfo();
            //myCar.ChangeColor();
            //myCar.ShoweInfo();

            //myCar carA = new CarA();
            //carA.OpenDoor();
            await MyHttpClientAsync();
        }

        static private async Task MyHttpClientAsync()
        {
            static readonly HttpClient client = new HttpClient();
            try	
            {
                string url = "http://www.contoso.com/";
                HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);
            }
            catch(HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");	
                Console.WriteLine("Message :{0} ",e.Message);
            }
        }
    }
}
