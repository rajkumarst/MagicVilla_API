using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> { 
        
            new VillaDTO{ Id=1, Name="Lake View Villa", Occupancy= 3, SqFt=100},
            new VillaDTO{ Id=2, Name="Beatch View Villa", Occupancy=4, SqFt=150}

        };
    }
}
