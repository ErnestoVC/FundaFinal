using System;

namespace FAS.Repository.viewModel
{
    public class DetalleViajeViewModel
    {
        public int Id {get;set;}
        public int ViajeId {get;set;}
        public int AsistenciaId {get;set;}
        public DateTime Fecha {get;set;}
        public double posX {get;set;}
        public double posY {get;set;}
        
    }
}