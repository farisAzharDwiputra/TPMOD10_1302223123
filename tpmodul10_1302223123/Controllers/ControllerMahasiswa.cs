using Microsoft.AspNetCore.Mvc;
using tpmodul10_1302223123.Model;

namespace tpmodul10_1302223123.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerMahasiswa : Controller
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa ("Farah Amalia Putri", "1302223137" ),
            new Mahasiswa ("Faris Azhar Dwiputra", "1302223123" ),
            new Mahasiswa ("Wildan Syukri Ni'am", "1302220005"),
            new Mahasiswa ("Muhammad Bintang Al-Fath", "1302223099"),
            new Mahasiswa ("Arga Adolf Lumunon", "1302223038"),
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
        }
    }
}
