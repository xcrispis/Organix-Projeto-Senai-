using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Domains;

namespace Backend.Interfaces
{
    public interface IOferta
    {
         Task<List<Oferta>> Listar();

         Task<Oferta> BuscarPorId(int id);
         
         Task<Oferta> Salvar(Oferta oferta);

         Task<Oferta> Alterar(Oferta oferta);

         Task<Oferta> Excluir(Oferta oferta);
    }
}