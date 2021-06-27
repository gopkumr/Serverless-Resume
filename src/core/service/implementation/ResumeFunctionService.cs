using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ResumeApp.Core.Service.Interface;
using ResumeApp.Core.Model;

namespace ResumeApp.Core.Service.Implementation{
public class ResumeFunctionService:IResumeService{
    private readonly HttpClient httpClient;
    private string apiUrl="/api/resume";

    public ResumeFunctionService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<Resume> GetResumeAsync(){
        Resume resume=null;
        var responseMessage= await httpClient.GetAsync(apiUrl);
        if(responseMessage.IsSuccessStatusCode)
        {
         resume = await responseMessage.Content.ReadFromJsonAsync<Resume>();
        }

        return resume;
    }
}

}