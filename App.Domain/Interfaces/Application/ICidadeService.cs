using System;
using System.Collections.Generic;
using App.Domain.Entities;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces.Application
{
    public interface ICidadeService
    {
        Cidade BuscaPorCep(String Cep);
        List<Cidade> ListaCidades();
        void Salvar(Cidade obj);
    }
}
