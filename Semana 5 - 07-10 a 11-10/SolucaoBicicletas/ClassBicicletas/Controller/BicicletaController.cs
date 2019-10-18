using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassBicicletas.Model;

namespace ClassBicicletas.Controller
{
    public class BicicletaController 
    {
        BicicletaContext bicicletinha = new BicicletaContext();
        /// <summary>
        /// Retorna a Lista
        /// </summary>
        /// <returns>Listar</returns>
        public IQueryable<Bicicleta> GetBicicletas()
        {
            return bicicletinha.bicicletas;
        }

        /// <summary>
        /// Método para Adicionar Bicicleta
        /// </summary>
        /// <param name="bicicleta">Enviar Info Bicicleta</param>
        /// <returns>Retorna se deu certo ou não</returns>
        public bool InserirBicicleta(Bicicleta bicicleta)
        {
            if (string.IsNullOrWhiteSpace(bicicleta.Marca))
                return false;
            if (string.IsNullOrWhiteSpace(bicicleta.Modelo))
                return false;
            else
            {
                bicicletinha.bicicletas.Add(bicicleta);
                bicicletinha.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Método para Atualizar um bicicleta existente
        /// </summary>
        /// <param name="bicicletaAtual">Enviar ID, Marca, Modelo, Valor. </param>
        /// <returns>Retorna true, com sucesso</returns>
        public bool AtualizarBicicleta(Bicicleta bicicletaAtual)
        {
            
            if (bicicletinha.bicicletas.FirstOrDefault<Bicicleta>().Id != bicicletaAtual.Id)
                return false;
            if (string.IsNullOrWhiteSpace(bicicletaAtual.Marca))
                return false;
            if (string.IsNullOrWhiteSpace(bicicletaAtual.Modelo))
                return false;
            if (bicicletaAtual.Valor < 0)
                return false;
            else
            {
                bicicletinha.bicicletas.Add(bicicletaAtual);
                bicicletinha.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Método que "exclui" uma bicicleta 
        /// </summary>
        /// <param name="IdparaExcluir">Enviar Id para desativar</param>
        /// <returns>Retorna se teve sucesso ou não, listar pro cliente</returns>
        public bool DesativarBicicleta(Bicicleta IdparaExcluir)
        {
            if (bicicletinha.bicicletas.Where(x => x.status == true).FirstOrDefault<Bicicleta>().Id != IdparaExcluir.Id)
                return false;
            else
            {
                bicicletinha.bicicletas.FirstOrDefault<Bicicleta>().status = false;
                bicicletinha.SaveChanges();
                return true;
            }
        }
    }
}
