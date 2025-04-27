using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022300093.Models;
using System.Collections.Generic;

namespace tpmodul10_103022300093.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Nama Kamu", Nim = "NIM Kamu" },
            new Mahasiswa { Nama = "Teman 1", Nim = "NIM Teman 1" },
            new Mahasiswa { Nama = "Teman 2", Nim = "NIM Teman 2" },
            new Mahasiswa { Nama = "Teman 3", Nim = "NIM Teman 3" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= listMahasiswa.Count)
                return NotFound();
            return listMahasiswa[index];
        }

        [HttpPost]
        public ActionResult Post([FromBody] Mahasiswa mhs)
        {
            listMahasiswa.Add(mhs);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= listMahasiswa.Count)
                return NotFound();
            listMahasiswa.RemoveAt(index);
            return Ok();
        }
    }
    
}