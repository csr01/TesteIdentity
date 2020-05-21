using System;
using System.Collections.Generic;
using System.Text;

namespace TesteIdentity.Model.Repository.Interfaces
{
    public interface IUnityOfWork
    {
        IProdutoRepository ProdutoRepository { get; }
        void save();
    }
}
