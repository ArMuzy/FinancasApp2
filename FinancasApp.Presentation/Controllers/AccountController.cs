﻿using FinancasApp.Domain.Interfaces.Services;
using FinancasApp.Presentation.Models.Account;
using Microsoft.AspNetCore.Mvc;

namespace FinancasApp.Presentation.Controllers
{
    /// <summary>
    /// Controlador para as páginas da pasta /Account
    /// </summary>
    public class AccountController : Controller
    {
        //Atributo
        private readonly IUsuarioDomainService? _usuarioDomainService;
       
        //construtor para inicializar o atributo (injeção de dependência)
        public AccountController(IUsuarioDomainService? usuarioDomainService)
        {
            _usuarioDomainService = usuarioDomainService;
        }

        /// <summary>
        /// Método para abrir a página /Account/Login
        /// </summary>
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Método para receber o SUBMIT POST da página /Account/Login
        /// </summary>
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return View();
        }

        /// <summary>
        /// Método para abrir a página /Account/Register
        /// </summary>
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Método para receber o SUBMIT POST da página /Account/Register
        /// </summary>
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            return View();
        }
    }
}
