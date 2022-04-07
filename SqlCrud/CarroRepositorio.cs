using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SqlCrud
{
    public class CarroRepositorio
    {
        protected DbContext _dbContext;

        public CarroRepositorio()
        {
            _dbContext = new DbContext();
        }

        public Carro Adicionar(Carro carro)
        {
            _dbContext.Conectar();

            string command = $"INSERT INTO Carro OUTPUT inserted.Id VALUES ('{carro.Modelo}', {carro.Ano})";
            SqlCommand cmd = new SqlCommand(command, _dbContext.SqlConnection);

            carro.Id = (int)cmd.ExecuteScalar();

            _dbContext.Desconectar();

            return carro;
        }
    }
}
