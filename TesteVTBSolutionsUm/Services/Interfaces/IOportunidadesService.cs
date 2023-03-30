using TesteVTBSolutionsUm.Dtos;

namespace TesteVTBSolutionsUm.Services.Interfaces
{
    public interface IOportunidadesService
    {
        public Task<Datum[]> FindAll();
        public Task<Datum> FindBy(string id);
        public Task Create(Datum datum);
        public Task Update(DatumAtualiza datum);
        public Task<bool> Delete(string id);
    }
}
