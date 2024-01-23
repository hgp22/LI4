﻿using BlazorServerAuthenticationAndAuthorization.Models;

namespace BlazorServerAuthenticationAndAuthorization.Controllers
{
    public interface ILicitacaoController
    {
        bool Create(Licitacao licitacao);
        bool Delete(Licitacao licitacao);
        bool MarkHasWinner(Licitacao licitacao);
        Licitacao GetByID(int id);
        List<Licitacao> GetAllDeUser(string username);
        List<Licitacao> GetAllDeLeilao(int leilaoID);
        
    }
}