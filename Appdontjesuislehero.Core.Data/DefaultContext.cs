using Appdontjesuislehero.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appdontjesuislehero.Core.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }
        #region properties
        public DbSet<Aventure> Aventures { get; set; }
        public DbSet<Paragraphe> Paragraphes { get; set; }
        #endregion
    }
}
