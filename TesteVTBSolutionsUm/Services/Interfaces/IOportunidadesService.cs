using TesteVTBSolutionsUm.Dtos;

namespace TesteVTBSolutionsUm.Services.Interfaces
{
    public interface IOportunidadesService
    {
        public Task<Datum[]> FindAll();
        public Task<Datum> FindBy(string id);
    }
}
