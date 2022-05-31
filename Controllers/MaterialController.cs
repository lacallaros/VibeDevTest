using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VibeDevTest.Data;
using VibeDevTest.Interfaces;
using VibeDevTest.Models;

namespace VibeDevTest.Controllers
{
    public class MaterialController : ControllerBase
    {
        private readonly IMaterialRepository mRep;

        public MaterialController(IMaterialRepository mRep)
        {
            this.mRep = mRep;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMaterials()
        {
            return Ok(await mRep.GetAllMaterialsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMaterialById(int id)
        {
            return Ok(await mRep.GetMaterialByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddMaterial(Material material)
        {
            return Ok(await mRep.AddMaterialAsync(material));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMaterial(Material request)
        {
            return Ok(await mRep.UpdateMaterialAsync(request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMaterial(int id)
        {
            return Ok(await mRep.DeleteMaterialByIdAsync(id));
        }
    }
}
