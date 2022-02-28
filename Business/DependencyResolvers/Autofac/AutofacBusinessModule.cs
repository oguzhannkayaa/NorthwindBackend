﻿using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>(); //eğer birisi IProductService türünde bişey isterse biz ProductManager veriyoruz
            builder.RegisterType<EfProductDal>().As<IProductDal>(); //eğer birisi IProductService türünde bişey isterse biz ProductManager veriyoruz
           
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>(); 
            builder.RegisterType<CategoryManager>().As<ICategoryService>();

            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<UserManager>().As<IUserService>();

            builder.RegisterType<AuthManager>().As<IAuthService>();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            

        }
    }
}
