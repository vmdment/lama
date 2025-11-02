using Lama.Config;
using Lama.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;

namespace Lama.Repositories
{
    public class MemberRepository
    {
        private readonly ConnectionDB _connectionDB;
        public MemberRepository(ConnectionDB connectionDB) 
        {
            _connectionDB = connectionDB;
        }
        public Member FindOneBy(string column, string value)
        {

            string query = $"SELECT TOP 1 * FROM members WHERE {column} = '{value}' ";
            SqlDataReader? sqlData = _connectionDB.Find(query);
            if (sqlData == null)
                throw new ArgumentNullException($"No existe miembro con : {column} {value}");
            return new Member(
                sqlData.GetInt32(0),
                sqlData.GetString(1),
                sqlData.GetString(2),
                sqlData.GetString(3),
                sqlData.GetString(4),
                sqlData.GetDateTime(5),
                sqlData.GetString(6),
                sqlData.GetInt32(7),
                sqlData.GetString(8),
                sqlData.GetString(9),
                sqlData.GetString(10),
                sqlData.GetDateTime(11),
                sqlData.GetString(12),
                sqlData.GetString(13),
                sqlData.GetString(14),
                sqlData.GetString(15),
                sqlData.GetString(16),
                sqlData.GetString(17),
                sqlData.GetString(18),
                sqlData.GetString(19),
                sqlData.GetInt32(20),
                sqlData.GetString(21),
                sqlData.GetInt32(22),
                sqlData.GetString(23),
                sqlData.GetDateTime(24),
                sqlData.GetDateTime(25)
            );
        }
        public IEnumerable<Member> FindAll()
        {
            LinkedList<Member> list = new LinkedList<Member>();
            string query = $"SELECT * FROM members ORDER BY Id ASC";
            SqlDataReader? sqlData = _connectionDB.Find(query);
            if (sqlData == null)
                return list;

            while (sqlData.NextResult()){
                list.Append(new Member(
                 sqlData.GetInt32(0),
                 sqlData.GetString(1),
                 sqlData.GetString(2),
                 sqlData.GetString(3),
                 sqlData.GetString(4),
                 sqlData.GetDateTime(5),
                 sqlData.GetString(6),
                 sqlData.GetInt32(7),
                 sqlData.GetString(8),
                 sqlData.GetString(9),
                 sqlData.GetString(10),
                 sqlData.GetDateTime(11),
                 sqlData.GetString(12),
                 sqlData.GetString(13),
                 sqlData.GetString(14),
                 sqlData.GetString(15),
                 sqlData.GetString(16),
                 sqlData.GetString(17),
                 sqlData.GetString(18),
                 sqlData.GetString(19),
                 sqlData.GetInt32(20),
                 sqlData.GetString(21),
                 sqlData.GetInt32(22),
                 sqlData.GetString(23),
                 sqlData.GetDateTime(24),
                 sqlData.GetDateTime(25)
             ));           
            }
          
              
            return list;
        }
        public Member Create(Member member)
        {
            int affected = _connectionDB.Execute($"INSERT INTO members(Id,Nombre,Apellido,Celular,CorreoElectronico,FechaIngreso,Direccion,Member,Cargo,Rango,Estatus,FechaNacimiento,Cedula,RH,EPS,Padrino,Foto,ContactoEmergencia,Ciudad,Moto,AnoModelo,Marca,CilindrajeCC,PlacaMatricula,FechaExpedicionLicenciaConduccion,FechaExpedicionSOAT) values ({member.Id},{member.Nombre},{member.Apellido},{member.Celular},{member.CorreoElectronico},{member.FechaIngreso},{member.Direccion},{member.member},{member.Cargo},{member.Rango},{member.Estatus},{member.FechaNacimiento},{member.Cedula},{member.RH},{member.EPS},{member.Padrino},{member.Foto},{member.ContactoEmergencia},{member.Ciudad},{member.Moto},{member.AnoModelo},{member.Marca},{member.CilindrajeCC},{member.PlacaMatricula},{member.FechaExpedicionLicenciaConduccion},{member.FechaExpedicionSOAT})");
            if (affected > 0)
                return member;
            throw new ArgumentNullException("No se logro crear el nuevo miembro");
                
        }
        public Member Update(string column, string value, string columnCondition, string valueCondition)
        {
            Member member = FindOneBy(column, value);
            string query = $"UPDATE members SET {column} = '{value}' WHERE {columnCondition} = '{valueCondition}'";
            int affected = _connectionDB.Execute(query);
            if (affected > 0)
                return member;
            throw new ArgumentNullException($"No se logro actualizar miembro {column} {value}");
        }
        public Member DeleteOneBy(string column, string value)
        {
            Member member = FindOneBy(column, value);
            string query = $"DELETE FROM members WHERE {column} = '{value}'";
            int affected = _connectionDB.Execute(query);
            if (affected > 0)
                return member;
            throw new ArgumentNullException($"No se logro eliminar miembro {column} {value}");
        }


    }
}
