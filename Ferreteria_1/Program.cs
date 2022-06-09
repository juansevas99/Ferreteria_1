namespace Ferreteria_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frame());
        }
    }
}


/*
 * 
 * Es este espacio se ahabla un poco del software en desarrollo y de algunas observaciones para mejorear el codigo
 * 
 * Requerimientos:
 * 1. El software permite administrar productos
 * 2. El sofweare permite al usaurio final visualizar los priductos
 * 3. El software permite administrar los pedidos
 * 
 * 
 * Observaciones
 * 
 * 1. Hubo un problema con vincular la lista para objectos de tipo ModeloPedidoProducto, ya que contiene objectos anidados
 * - Se resolvio sobrescribiendo el metodo ToString para los objectos pedido y producto sin embargo, en el GridDataView no se puede actualizar, ya que presenta un problema de casting lo cual ya se esperaba
 * - 
 * 2. la arquitectura en el diseño forza a cfrear nuevas instancias de forms, lo cual forza a perder referencias a objectos, propiedades de elementos modificadas 
 * y demas, ademas de que consume mucha memoria. 
 * - Una alternativa es que cada vez que se pretenda cambiar de form, se acceda al form que anteriormente ha sido guardado de manera statica
 * 
 * 
 * 3. El acceso de controladores desde otros controladores produce algunos problemas. Esta en discusion si debe crearse logica especifica para el accesso desde otros contronladores.
 * 4. En caso de que se resuelva el problema de los forms y la creacion de instancias, ya no seria necesario el uso de patron singleton
 * 
 * 5. FAlta aun hallar la manera de deplegar datos en forma de carta para los productos
 * 
 * 
 * 
 * 