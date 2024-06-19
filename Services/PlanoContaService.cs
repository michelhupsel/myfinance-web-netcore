using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using myfinance_web_netcore.Infrastructure;
using myfinance_web_netcore.Models;

namespace myfinance_web_netcore.Services
{
    public class PlanoContaService : IPlanoContaService
    {
        private readonly IMapper _mapper;

        private readonly MyFinanceDbContext _myFinanceDbContext;

        public PlanoContaService(MyFinanceDbContext myFinanceDbContext,
                IMapper mapper)
        {
            _myFinanceDbContext = myFinanceDbContext;
            _mapper = mapper;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<PlanoContaModel> ListarRegistros()
        {
            throw new NotImplementedException();
        }

        public PlanoContaModel RetornarRegistro(int id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(PlanoContaModel model)
        {
            throw new NotImplementedException();
        }
    }
}