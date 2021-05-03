using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AutoPecas.Persistencia
{
    public abstract class Banco
    {
        public abstract bool Conecta();
        public abstract void Desconecta();
        public abstract void BeginTransaction();
        public abstract void RollbackTransaction();
        public abstract void CommitTransaction();
        public abstract bool ExecuteQuery(String sql, out DataTable dt, params Object[] parametros);
        public abstract bool ExecuteNonQuery(String sql, params Object[] parametros);
        public abstract int GetIdentity();
    }
}
