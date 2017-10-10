﻿using PetHealthAPI.Models;
using PetHealthAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;

namespace PetHealthAPI.Controllers
{
    [RoutePrefix("pet")]
    public class PetController : BaseController
    {
        [HttpPost]
        public JsonResult addPet(PetJsonObject petJsonObject)
        {
            Pet newPet = new Pet();
            var msg = "error";
            try
            {
                using (var trans = new TransactionScope())
                {
                    if (petJsonObject.petId == null)
                    {
                        context.Pet.Add(newPet);
                    }
                    else
                    {
                        newPet = context.Pet.Find(petJsonObject.petId);
                    }
                    newPet.BirthDate = Convert.ToDateTime(petJsonObject.birthDate);
                    newPet.Description = petJsonObject.description;
                    newPet.Key = petJsonObject.key;
                    newPet.Name = petJsonObject.name;
                    newPet.OwnerId = petJsonObject.ownerId;
                    newPet.Race = petJsonObject.race;
                    newPet.Status = petJsonObject.status;
                    context.SaveChanges();
                    trans.Complete();
                    msg = "success";
                }

            }catch(Exception e)
            {
                
            }
            return Json(new { message=msg }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult delete(int petId)
        {
            var msg = "error";
            var pet = context.Pet.Find(petId);
            if ( pet != null)
            {
                using (var trans = new TransactionScope())
                {
                    context.Pet.Remove(pet);
                    msg = "success";
                }
            }
            return Json(new { message = msg }, JsonRequestBehavior.AllowGet);
        }
    }
}