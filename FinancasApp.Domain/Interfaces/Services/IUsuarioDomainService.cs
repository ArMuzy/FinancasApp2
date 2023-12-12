using FinancasApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Domain.Interfaces.Services
{/// <summary>
/// Interface de serviço de domínio para a emntidade Usuário
/// </summary>
    public interface IUsuarioDomainService
    {
        void CriarUsuario(Usuario usuario);

    }
}
