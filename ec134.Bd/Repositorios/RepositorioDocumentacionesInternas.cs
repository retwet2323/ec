using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioDocumentacionesInternas : RepositorioDocumentacionesInternasBase, IRepositorioDocumentacionesInternas
	{
        ec134Context _dbContext;
        public RepositorioDocumentacionesInternas (ec134Context dbContext) : base(dbContext)
		{
            _dbContext = dbContext;
        }

        public DocumentacionesInternas GetDocumentacionInternaPlantilla(int idPlantilla)
        {
            var plantilla = _dbContext.DocumentosPlantillas.First(dp => dp.IdDocumentoPlantilla == idPlantilla);
            var version = _dbContext.VersionesElementos.Where(v => v.IdElementoVersionable == plantilla.IdElemento).OrderByDescending(v => v.IdElemento).First();
            return GetDocumentacionesInternas().FirstOrDefault(di => di.IdDocumentacionInterna == version.IdElemento);
            //TODO: Mejorar para ver cual es la versión activa. (Ahora sólo cojemos la más reciente).
        }

    }
}
