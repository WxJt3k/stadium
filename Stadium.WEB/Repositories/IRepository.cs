using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stadium.WEB.Repositories.Web.Repositories;

namespace Stadium.WEB.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);

        Task<HttpResponseWrapper<Object>> Post<T>(String url, T model);

        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T model);

        Task<HttpResponseWrapper<Object>> Delete(string url);

        Task<HttpResponseWrapper<Object>> Put<T>(String url, T model);

        Task<HttpResponseWrapper<TResponse>> Put<T, TResponse>(String url, T model);

        Task<HttpResponseWrapper<object>> Get(string url);
    }
}
