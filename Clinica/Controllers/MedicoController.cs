using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;
using System.Data.Entity.Migrations;

namespace Clinica.Controllers
{
    [DataObject(true)]
    public partial class MedicoController
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MEDICO selectMedico (int id)
        {
            #region SQL
            string sql = @"SELECT * FROM TB_MEDICO 
                           WHERE med_id = @med_id";
            #endregion
            ConnectionStringSettingsCollection strConnection = ConfigurationManager.ConnectionStrings;
            SqlConnection cn = new SqlConnection(strConnection["ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);

            cmd.Parameters.Add(new SqlParameter("@med_id", id));

            MEDICO med = null;

            try
            {
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    med = new MEDICO();
                    med.med_id = (int)reader["med_id"];
                    med.med_nom = (string)reader["med_nom"];
                    med.med_end = (string)reader["med_end"];
                    med.med_cpf = (string)reader["med_cpf"];
                    med.med_fone = (int)reader["med_fone"];
                    med.med_crm = (string)reader["med_crm"];
                    med.med_cidade = (string)reader["med_cidade"];
                    med.med_estado = (string)reader["med_estado"];
                    med.med_qtd_atend = (int)reader["med_qtd_atend"];
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return med;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static int adcionarMedico(MEDICO medico)
        {
            #region SQL
            string sql = @"INSERT INTO TB_MEDICO (@med_nom, @med_end, @med_cpf, @med_fone, @med_crm, @med_cidade, @med_estado, @med_qtd_atend)";
            #endregion

            ConnectionStringSettingsCollection strConnection = ConfigurationManager.ConnectionStrings;
            SqlConnection cn = new SqlConnection(strConnection["ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);

            cmd.Parameters.Add(new SqlParameter("@med_nom", medico.med_nom));
            cmd.Parameters.Add(new SqlParameter("@med_end", medico.med_end));
            cmd.Parameters.Add(new SqlParameter("@med_cpf", medico.med_cpf));
            cmd.Parameters.Add(new SqlParameter("@med_fone", medico.med_fone));
            cmd.Parameters.Add(new SqlParameter("@med_crm", medico.med_crm));
            cmd.Parameters.Add(new SqlParameter("@med_cidade", medico.med_cidade));
            cmd.Parameters.Add(new SqlParameter("@med_estado", medico.med_estado));
            cmd.Parameters.Add(new SqlParameter("@med_qtd_atend", medico.med_qtd_atend));
            int linhasAfetadas = -1;

            try
            {
                cn.Open();
                linhasAfetadas = cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return linhasAfetadas;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public static int deletarMedico (MEDICO medico)
        {
            #region SQL
            string sql = @"DELETE FROM TB_MEDICO 
                           WHERE med_id = @med_id";
            #endregion

            ConnectionStringSettingsCollection strConnection = ConfigurationManager.ConnectionStrings;
            SqlConnection cn = new SqlConnection(strConnection["ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);

            cmd.Parameters.Add(new SqlParameter("@med_id", medico.med_id));

            int linhasAfetadas = -1;

            try
            {
                cn.Open();
                linhasAfetadas = cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return linhasAfetadas;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public static int atualizarMedico(MEDICO medico)
        {
            #region SQL
            string sql = @"UPDATE TB_MEDICO
                            SET med_nom = @med_nom,
                                med_end = @med_end,
                                med_cpf = @med_cpf,
                                med_fone = @med_fone,
                                med_crm = @med_crm,
                                med_cidade = @med_cidade,
                                med_estado = @med_estado,
                                med_qtd_atend = @med_qtd_atend
                            WHERE med_id = @med_id";
            #endregion

            ConnectionStringSettingsCollection strConnection = ConfigurationManager.ConnectionStrings;
            SqlConnection cn = new SqlConnection(strConnection["ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);

            cmd.Parameters.Add(new SqlParameter("@med_nom", medico.med_nom));
            cmd.Parameters.Add(new SqlParameter("@med_end", medico.med_end));
            cmd.Parameters.Add(new SqlParameter("@med_cpf", medico.med_cpf));
            cmd.Parameters.Add(new SqlParameter("@med_fone", medico.med_fone));
            cmd.Parameters.Add(new SqlParameter("@med_crm", medico.med_crm));
            cmd.Parameters.Add(new SqlParameter("@med_cidade", medico.med_cidade));
            cmd.Parameters.Add(new SqlParameter("@med_estado", medico.med_estado));
            cmd.Parameters.Add(new SqlParameter("@med_qtd_atend", medico.med_qtd_atend));
            int linhasAfetadas = -1;

            try
            {
                cn.Open();
                linhasAfetadas = cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return linhasAfetadas;
        }
    }
}