using System.Threading.Tasks;
using ResumeApp.Core.Model;

namespace ResumeApp.Core.Service.Interface{
public interface IResumeService{
    Task<Resume> GetResumeAsync();
}

}