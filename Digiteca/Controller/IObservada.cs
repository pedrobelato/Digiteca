using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Digiteca.Controller
{
    public interface IObservada
    {
        void adicionarObservadores(IObservador observador);//Permita que observadores sejam cadastrados
        void notificarObservadores();//Quando houver alteração em meu estado, irei notificar quem está me observando
        
    }
}