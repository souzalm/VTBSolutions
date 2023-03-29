using TesteVTBSolutionsUm.Dtos;

namespace TesteVTBSolutionsUm.Services.Interfaces
{
    public interface IOportunidadesService
    {
        public Task<OportunidadeDto> FindBy(int id);
    }
}
