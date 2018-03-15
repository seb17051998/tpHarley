using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using codeFirstDAL;
using codeFirstDTO;
using System.Data.Entity;


namespace codeFirstDAL
{
    
        public class HarleyProvider
        {
            public HarleyProvider()
            {
            }
            public List<EntityHarley> GetAllHarleys()
            {
                using (GarageContext context = new GarageContext())
                {
                    return context.Harleys.ToList();
                }
            }
            public void Create(EntityHarley Harley)
            {
                using (GarageContext context = new GarageContext())
                {
                    try
                    {
                        context.Harleys.Add(Harley);
                        context.SaveChanges();
                    }
                    catch
                    {
                        throw;
                    }

                }
            }
            public void Update(EntityHarley Harley)
            {
                using (GarageContext context = new GarageContext())
                {
                    try
                    {
                        context.Harleys.Attach(Harley);
                        // Très important, signifier le fait que l'entité a été modifiée.
                        context.Entry<EntityHarley>(Harley).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                    catch
                    {
                        throw;
                    }
                }
            }

            public void Delete(EntityHarley Harley)
            {
                using (GarageContext context = new GarageContext())
                {
                    try
                    {
                        context.Harleys.Attach(Harley);
                        context.Harleys.Remove(Harley);
                        context.SaveChanges();
                    }
                    catch
                    {
                        throw;
                    }
                }
            }

            }
        }
   

