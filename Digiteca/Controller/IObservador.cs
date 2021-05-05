using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Digiteca.Controller
{
    public interface IObservador
    {
        void notificar(string acao, params Object[] parametros);
    }
}
