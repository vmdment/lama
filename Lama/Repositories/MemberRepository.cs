using Lama.Config;
using Lama.Models;
using Microsoft.Data.SqlClient;

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

            string query = $"SELECT TOP 1 * FROM Miembros WHERE {column} = '{value}' ";
            IEnumerable<Member> members = _connectionDB.Find(query);
            return members.First();

        }
        public IEnumerable<Member> FindAll()
        {
            
            string query = $"SELECT * FROM Miembros ORDER BY Id ASC";
            IEnumerable<Member> list = _connectionDB.Find(query);                       
            return list;
        }
        public Member Create(Member member)
        {
            int affected = _connectionDB.Execute($"INSERT INTO Miembros(Nombre,Apellido,Celular,CorreoElectronico,FechaIngreso,Direccion,Member,Cargo,Rango,Estatus,FechaNacimiento,Cedula,RH,EPS,Padrino,Foto,ContactoEmergencia,Ciudad,Moto,AnoModelo,Marca,CilindrajeCC,PlacaMatricula,FechaExpedicionLicenciaConduccion,FechaExpedicionSOAT) values ('{member.Nombre}','{member.Apellido}','{member.Celular}','{member.CorreoElectronico}','{member.FechaIngreso.Value.ToString("s")}','{member.Direccion}','{member.member}','{member.Cargo}','{member.Rango}','{member.Estatus}','{member.FechaNacimiento.Value.ToString("s")}','{member.Cedula}','{member.RH}','{member.EPS}','{member.Padrino}','{member.Foto}','{member.ContactoEmergencia}','{member.Ciudad}','{member.Moto}','{member.AnoModelo}','{member.Marca}','{member.CilindrajeCC}','{member.PlacaMatricula}','{member.FechaExpedicionLicenciaConduccion.Value.ToString("s")}','{member.FechaExpedicionSOAT.Value.ToString("s")}')");
            if (affected > 0)
                return member;
            throw new ArgumentNullException("No se logro crear el nuevo miembro");
                
        }
        public Member Update(string column, string value, string columnCondition, string valueCondition)
        {
            Member member = FindOneBy(column, value);
            string query = $"UPDATE Miembros SET {column} = '{value}' WHERE {columnCondition} = '{valueCondition}'";
            int affected = _connectionDB.Execute(query);
            if (affected > 0)
                return member;
            throw new ArgumentNullException($"No se logro actualizar miembro {column} {value}");
        }
        public Member DeleteOneBy(string column, string value)
        {
            Member member = FindOneBy(column, value);
            string query = $"DELETE FROM Miembros WHERE {column} = '{value}'";
            int affected = _connectionDB.Execute(query);
            if (affected > 0)
                return member;
            throw new ArgumentNullException($"No se logro eliminar miembro {column} {value}");
        }


    }
}
