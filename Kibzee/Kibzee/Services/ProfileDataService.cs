using Kibzee.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kibzee.Services
{
    public class ProfileDataService
    {
        private readonly Models.KibzeeMainContext _context;

        public ProfileDataService(Models.KibzeeMainContext context)
        {
            _context = context;
        }

        public async Task<List<UserInstruments>> GetUserInstrumentsByUserId(int userid)
        {
            List<UserInstruments> InstrumentList = await _context.UserInstruments.Where(p => p.UserId == userid).ToListAsync();
            return InstrumentList;
        }

        public async Task<List<Instruments>> GetInstrumentsByInstrumentId(int instid)
        {
            List<Instruments> InstrumentList = await _context.Instruments.Where(p => p.InstId == instid).ToListAsync();
            return InstrumentList;
        }

        public async Task<List<Instruments>> GetInstrumentsByUserId(int userid)
        {
            List<UserInstruments> UserInstrumentList = await _context.UserInstruments.Where(p => p.UserId == userid).ToListAsync();
            List<Instruments> InstrumentList = new List<Instruments>();
            foreach (UserInstruments userInst in UserInstrumentList)
            {
                List<Instruments> PartialInstrumentList = await _context.Instruments.Where(p => p.InstId == userInst.InstrumentId).ToListAsync();
                foreach (Instruments inst in PartialInstrumentList) 
                    if (!InstrumentList.Contains(inst)) 
                        InstrumentList.Add(inst);
            }
            return InstrumentList;
        }


        public async Task<ContactDetails> GetContactDetailsByUserId(int userid)
        {
            List<ContactDetails> FullContactDetailsList = await _context.ContactDetails.Where(p => p.UserId == userid).ToListAsync();
            if (FullContactDetailsList.Count > 1) throw new Exception("Duplicate UserID Error");
            return FullContactDetailsList.First();
        }

        public async Task<int> GetUserIDFromEmail(string email)
        {
            List<ContactDetails> FullContactDetailsList = await _context.ContactDetails.Where(p => p.Email == email).ToListAsync();
            if (FullContactDetailsList.Count > 1) throw new Exception("Duplicate UserID Error");
            ContactDetails cd =  FullContactDetailsList.First();
            return cd.UserId;
        }

        public async Task<bool> IsProfileComplete(int userid)
        {
            return true;
        }
    }
}
