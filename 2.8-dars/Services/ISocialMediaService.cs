using _2._8_dars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._8_dars.Services;

public class ISocialMediaService
{
    public Guid Add(SocialMedia socialMedia);
    public List<SocialMedia> GetAll();
    public SocialMedia? GetById(Guid id);
    public bool Update(Guid id, SocialMedia socialMedia);
    public bool Delete(Guid id);
}
