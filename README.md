# 🧩 MiniTrello SaaS API

**Projeto Demo** em `.NET 8 Minimal API` inspirado no Trello, com foco em arquitetura SaaS multi-tenant, autenticação via Google, e integração com IA usando a API da DeepSeek. Ideal para apresentar skills modernas em backend com visão de produto e escalabilidade.

---

## 🚀 Visão Geral

O **MiniTrello SaaS** permite que múltiplos usuários (ou empresas) gerenciem quadros, listas e cartões de forma independente — cada tenant com seu espaço isolado. A API fornece recursos de autenticação, gerenciamento de tarefas e inteligência artificial para insights automáticos.

---

## 🧠 Funcionalidades

- ✅ Autenticação via Google + JWT
- ✅ Multi-tenant via `X-Tenant-ID`
- ✅ CRUD de Boards, Lists e Cards
- ✅ IA com DeepSeek para sugestões e resumos
- ✅ Arquitetura em camadas (API, Application, Domain, Infrastructure)
- ✅ Swagger com documentação automática
- ✅ Deploy-ready no [Railway](https://railway.app/) ou [Render](https://render.com/)

---

## 📚 Stack Técnica

- [.NET 8 Minimal API](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis)
- Entity Framework Core + PostgreSQL
- AutoMapper
- JWT Auth
- DeepSeek API (LLM)
- Docker (opcional)
- Railway (deploy)

---

## 📦 Instalação

```bash
git clone https://github.com/seu-usuario/minitrello-saas.git
cd minitrello-saas


