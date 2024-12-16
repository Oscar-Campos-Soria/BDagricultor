using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDagricultor
{
    public class PersonaDat
    {
        public static int AgregarPersona(Persona persona)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = " insert into Agricultor (nombre,edad,experiencia) values('" + persona.nombre + "' , " + persona.edad + " , '" + persona.experiencia + "'      )";
                SqlCommand command = new SqlCommand(query, conexion);

                retorna = command.ExecuteNonQuery();
            }

            return retorna;
        }

        public static List<Persona> PresentarRegistro()
        {

            List<Persona> Lista = new List<Persona>();

            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {

                string query = "select *from agricultor";
                SqlCommand command = new SqlCommand(query, conexion);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Persona persona = new Persona();
                    persona.id = reader.GetInt32(0);
                    persona.nombre = reader.GetString(1);
                    persona.edad = reader.GetInt32(2);
                    persona.experiencia = reader.GetString(3);
                    Lista.Add(persona);

                }
                conexion.Close();
                return Lista;

            }

        }

        public static int ModificarPersona(Persona persona)
        {
            int result = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "update agricultor set nombre='" + persona.nombre + "', edad=" + persona.edad + " ,experiencia= '" + persona.experiencia + "' where id=" + persona.id + " ";
                SqlCommand comando = new SqlCommand(query, conexion);


                result = comando.ExecuteNonQuery();
                conexion.Close();

            }

            return result;
        }

        public static int EliminarPersona(int id)
        {
            int retorna = 0;

            // Crear una conexión dentro del bloque using
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                // Usa parámetros para evitar inyección SQL
                string query = "DELETE FROM Agricultor WHERE id = @id"; // Asegúrate de que el nombre de la tabla sea correcto
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@id", id);

                // Ejecuta la consulta
                retorna = command.ExecuteNonQuery();
            }

            return retorna;
        }

        public static int AgregarCultivo(Cultivo cultivo)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "INSERT INTO Cultivo (nombreCultivo, temporada, idAgricultor) VALUES (@nombreCultivo, @temporada, @idAgricultor)";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@nombreCultivo", cultivo.nombreCultivo);
                command.Parameters.AddWithValue("@temporada", cultivo.temporada);
                command.Parameters.AddWithValue("@idAgricultor", cultivo.idAgricultor);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }


        public static List<Cultivo> MostrarCultivos()
        {
            List<Cultivo> lista = new List<Cultivo>();
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "SELECT * FROM Cultivo";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cultivo cultivo = new Cultivo
                    {
                        idCultivo = reader.GetInt32(0),
                        nombreCultivo = reader.GetString(1),
                        temporada = reader.GetString(2),
                        idAgricultor = reader.GetInt32(3)
                    };
                    lista.Add(cultivo);
                }
            }
            return lista;
        }
        public static int ModificarCultivo(Cultivo cultivo)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "UPDATE Cultivo SET nombreCultivo = @nombreCultivo, temporada = @temporada, idAgricultor = @idAgricultor WHERE idCultivo = @idCultivo";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idCultivo", cultivo.idCultivo);
                command.Parameters.AddWithValue("@nombreCultivo", cultivo.nombreCultivo);
                command.Parameters.AddWithValue("@temporada", cultivo.temporada);
                command.Parameters.AddWithValue("@idAgricultor", cultivo.idAgricultor);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }
        public static int EliminarCultivo(int idCultivo)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "DELETE FROM Cultivo WHERE idCultivo = @idCultivo";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idCultivo", idCultivo);

                retorna = command.ExecuteNonQuery();
            }

            return retorna;
        }


        public static int AgregarCliente(Cliente cliente)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "INSERT INTO Cliente (nombreCliente, direccion, telefono) VALUES (@nombreCliente, @direccion, @telefono)";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@nombreCliente", cliente.nombreCliente);
                command.Parameters.AddWithValue("@direccion", cliente.direccion);
                command.Parameters.AddWithValue("@telefono", cliente.telefono);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<Cliente> MostrarClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "SELECT * FROM Cliente";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        idCliente = reader.GetInt32(0),
                        nombreCliente = reader.GetString(1),
                        direccion = reader.GetString(2),
                        telefono = reader.GetString(3)
                    };
                    lista.Add(cliente);
                }
            }
            return lista;
        }

        public static int ModificarCliente(Cliente cliente)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "UPDATE Cliente SET nombreCliente = @nombreCliente, direccion = @direccion, telefono = @telefono WHERE idCliente = @idCliente";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idCliente", cliente.idCliente);
                command.Parameters.AddWithValue("@nombreCliente", cliente.nombreCliente);
                command.Parameters.AddWithValue("@direccion", cliente.direccion);
                command.Parameters.AddWithValue("@telefono", cliente.telefono);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int EliminarCliente(int idCliente)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "DELETE FROM Cliente WHERE idCliente = @idCliente";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idCliente", idCliente);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }



        public static List<Proveedor> MostrarProveedores()
        {
            List<Proveedor> lista = new List<Proveedor>();
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "SELECT * FROM Proveedor";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Proveedor proveedor = new Proveedor
                    {
                        idProveedor = reader.GetInt32(0),
                        nombreProveedor = reader.GetString(1),
                        telefono = reader.GetString(2),
                        direccion = reader.GetString(3)
                    };
                    lista.Add(proveedor);
                }
            }
            return lista;
        }

        public static int AgregarProveedor(Proveedor proveedor)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "INSERT INTO Proveedor (nombreProveedor, telefono, direccion) VALUES (@nombreProveedor, @telefono, @direccion)";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@nombreProveedor", proveedor.nombreProveedor);
                command.Parameters.AddWithValue("@telefono", proveedor.telefono);
                command.Parameters.AddWithValue("@direccion", proveedor.direccion);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;

        }

        public static int ModificarProveedor(Proveedor proveedor)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "UPDATE Proveedor SET nombreProveedor = @nombreProveedor, telefono = @telefono, direccion = @direccion WHERE idProveedor = @idProveedor";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idProveedor", proveedor.idProveedor);
                command.Parameters.AddWithValue("@nombreProveedor", proveedor.nombreProveedor);
                command.Parameters.AddWithValue("@telefono", proveedor.telefono);
                command.Parameters.AddWithValue("@direccion", proveedor.direccion);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int EliminarProveedor(int idProveedor)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "DELETE FROM Proveedor WHERE idProveedor = @idProveedor";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idProveedor", idProveedor);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }



        public static int AgregarProduccion(Produccion produccion)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "INSERT INTO Produccion (cantidad, calidad, fechaProduccion, idCultivo) VALUES (@cantidad, @calidad, @fechaProduccion, @idCultivo)";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@cantidad", produccion.cantidad);
                command.Parameters.AddWithValue("@calidad", produccion.calidad);
                command.Parameters.AddWithValue("@fechaProduccion", produccion.fechaProduccion);
                command.Parameters.AddWithValue("@idCultivo", produccion.idCultivo);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<Produccion> MostrarProducciones()
        {
            List<Produccion> lista = new List<Produccion>();
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "SELECT * FROM Produccion";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Produccion produccion = new Produccion
                    {
                        idProduccion = reader.GetInt32(0),
                        cantidad = reader.GetDecimal(1),
                        calidad = reader.GetString(2),
                        fechaProduccion = reader.GetDateTime(3),
                        idCultivo = reader.GetInt32(4)
                    };
                    lista.Add(produccion);
                }
            }
            return lista;
        }

        public static int ModificarProduccion(Produccion produccion)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "UPDATE Produccion SET cantidad = @cantidad, calidad = @calidad, fechaProduccion = @fechaProduccion, idCultivo = @idCultivo WHERE idProduccion = @idProduccion";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idProduccion", produccion.idProduccion);
                command.Parameters.AddWithValue("@cantidad", produccion.cantidad);
                command.Parameters.AddWithValue("@calidad", produccion.calidad);
                command.Parameters.AddWithValue("@fechaProduccion", produccion.fechaProduccion);
                command.Parameters.AddWithValue("@idCultivo", produccion.idCultivo);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int EliminarProduccion(int idProduccion)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "DELETE FROM Produccion WHERE idProduccion = @idProduccion";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idProduccion", idProduccion);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }


        public static int AgregarPlaga(Plaga plaga)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "INSERT INTO Plaga (nombrePlaga, tipoPlaga, nivelDanio, idCultivo) VALUES (@nombrePlaga, @tipoPlaga, @nivelDanio, @idCultivo)";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@nombrePlaga", plaga.nombrePlaga);
                command.Parameters.AddWithValue("@tipoPlaga", plaga.tipoPlaga);
                command.Parameters.AddWithValue("@nivelDanio", plaga.nivelDanio);
                command.Parameters.AddWithValue("@idCultivo", plaga.idCultivo);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<Plaga> MostrarPlagas()
        {
            List<Plaga> lista = new List<Plaga>();
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "SELECT * FROM Plaga";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Plaga plaga = new Plaga
                    {
                        idPlaga = reader.GetInt32(0),
                        nombrePlaga = reader.GetString(1),
                        tipoPlaga = reader.GetString(2),
                        nivelDanio = reader.GetString(3),
                        idCultivo = reader.GetInt32(4)
                    };
                    lista.Add(plaga);
                }
            }
            return lista;
        }


        public static int ModificarPlaga(Plaga plaga)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "UPDATE Plaga SET nombrePlaga = @nombrePlaga, tipoPlaga = @tipoPlaga, nivelDanio = @nivelDanio, idCultivo = @idCultivo WHERE idPlaga = @idPlaga";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idPlaga", plaga.idPlaga);
                command.Parameters.AddWithValue("@nombrePlaga", plaga.nombrePlaga);
                command.Parameters.AddWithValue("@tipoPlaga", plaga.tipoPlaga);
                command.Parameters.AddWithValue("@nivelDanio", plaga.nivelDanio);
                command.Parameters.AddWithValue("@idCultivo", plaga.idCultivo);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int EliminarPlaga(int idPlaga)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "DELETE FROM Plaga WHERE idPlaga = @idPlaga";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idPlaga", idPlaga);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }


        public static int AgregarPedido(Pedido pedido)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "INSERT INTO Pedido (fechaPedido, cantidad, idProveedor) VALUES (@fechaPedido, @cantidad, @idProveedor)";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@fechaPedido", pedido.fechaPedido);
                command.Parameters.AddWithValue("@cantidad", pedido.cantidad);
                command.Parameters.AddWithValue("@idProveedor", pedido.idProveedor);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<Pedido> MostrarPedidos()
        {
            List<Pedido> lista = new List<Pedido>();
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "SELECT * FROM Pedido";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Pedido pedido = new Pedido
                    {
                        idPedido = reader.GetInt32(0),
                        fechaPedido = reader.GetDateTime(1),
                        cantidad = reader.GetDecimal(2),
                        idProveedor = reader.GetInt32(3)
                    };
                    lista.Add(pedido);
                }
            }
            return lista;
        }


        public static int ModificarPedido(Pedido pedido)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "UPDATE Pedido SET fechaPedido = @fechaPedido, cantidad = @cantidad, idProveedor = @idProveedor WHERE idPedido = @idPedido";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idPedido", pedido.idPedido);
                command.Parameters.AddWithValue("@fechaPedido", pedido.fechaPedido);
                command.Parameters.AddWithValue("@cantidad", pedido.cantidad);
                command.Parameters.AddWithValue("@idProveedor", pedido.idProveedor);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int EliminarPedido(int idPedido)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "DELETE FROM Pedido WHERE idPedido = @idPedido";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idPedido", idPedido);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }


        public static int AgregarVenta(Venta venta)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "INSERT INTO Venta (fechaVenta, cantidadVendida, precioUnitario, idProduccion, idCliente) VALUES (@fechaVenta, @cantidadVendida, @precioUnitario, @idProduccion, @idCliente)";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@fechaVenta", venta.fechaVenta);
                command.Parameters.AddWithValue("@cantidadVendida", venta.cantidadVendida);
                command.Parameters.AddWithValue("@precioUnitario", venta.precioUnitario);
                command.Parameters.AddWithValue("@idProduccion", venta.idProduccion);
                command.Parameters.AddWithValue("@idCliente", venta.idCliente);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }
        public static List<Venta> MostrarVentas()
        {
            List<Venta> lista = new List<Venta>();
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "SELECT * FROM Venta";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Venta venta = new Venta
                    {
                        idVenta = reader.GetInt32(0),
                        fechaVenta = reader.GetDateTime(1),
                        cantidadVendida = reader.GetDecimal(2),
                        precioUnitario = reader.GetDecimal(3),
                        idProduccion = reader.GetInt32(4),
                        idCliente = reader.GetInt32(5)
                    };
                    lista.Add(venta);
                }
            }
            return lista;
        }
        public static int ModificarVenta(Venta venta)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "UPDATE Venta SET fechaVenta = @fechaVenta, cantidadVendida = @cantidadVendida, precioUnitario = @precioUnitario, idProduccion = @idProduccion, idCliente = @idCliente WHERE idVenta = @idVenta";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idVenta", venta.idVenta);
                command.Parameters.AddWithValue("@fechaVenta", venta.fechaVenta);
                command.Parameters.AddWithValue("@cantidadVendida", venta.cantidadVendida);
                command.Parameters.AddWithValue("@precioUnitario", venta.precioUnitario);
                command.Parameters.AddWithValue("@idProduccion", venta.idProduccion);
                command.Parameters.AddWithValue("@idCliente", venta.idCliente);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int EliminarVenta(int idVenta)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "DELETE FROM Venta WHERE idVenta = @idVenta";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idVenta", idVenta);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }


        public static int AgregarGasto(Gasto gasto)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "INSERT INTO Gasto (descripcion, monto, fechaGasto, idCultivo) VALUES (@descripcion, @monto, @fechaGasto, @idCultivo)";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@descripcion", gasto.descripcion);
                command.Parameters.AddWithValue("@monto", gasto.monto);
                command.Parameters.AddWithValue("@fechaGasto", gasto.fechaGasto);
                command.Parameters.AddWithValue("@idCultivo", gasto.idCultivo);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<Gasto> MostrarGastos()
        {
            List<Gasto> lista = new List<Gasto>();
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "SELECT * FROM Gasto";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Gasto gasto = new Gasto
                    {
                        idGasto = reader.GetInt32(0),
                        descripcion = reader.GetString(1),
                        monto = reader.GetDecimal(2),
                        fechaGasto = reader.GetDateTime(3),
                        idCultivo = reader.GetInt32(4)
                    };
                    lista.Add(gasto);
                }
            }
            return lista;
        }

        public static int EliminarGasto(int idGasto)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "DELETE FROM Gasto WHERE idGasto = @idGasto";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idGasto", idGasto);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }



        public static int AgregarEmpleado(Empleado empleado)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "INSERT INTO Empleado (nombreEmpleado, puesto, salario, idAgricultor) VALUES (@nombreEmpleado, @puesto, @salario, @idAgricultor)";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@nombreEmpleado", empleado.nombreEmpleado);
                command.Parameters.AddWithValue("@puesto", empleado.puesto);
                command.Parameters.AddWithValue("@salario", empleado.salario);
                command.Parameters.AddWithValue("@idAgricultor", empleado.idAgricultor);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<Empleado> MostrarEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "SELECT * FROM Empleado";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Empleado empleado = new Empleado
                    {
                        idEmpleado = reader.GetInt32(0),
                        nombreEmpleado = reader.GetString(1),
                        puesto = reader.GetString(2),
                        salario = reader.GetDecimal(3),
                        idAgricultor = reader.GetInt32(4)
                    };
                    lista.Add(empleado);
                }
            }
            return lista;
        }

        public static int EliminarEmpleado(int idEmpleado)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDAgricultor.obtenerconexion())
            {
                string query = "DELETE FROM Empleado WHERE idEmpleado = @idEmpleado";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }



    }

}


      
