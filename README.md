# VSLIVE! 2025 San Diego - Hands-On Lab

**Build a Copilot Agent Now with C# and Modern DevOps**

Welcome to the hands-on lab repository for Visual Studio Live! 2025 San Diego. This full-day workshop teaches you how to build AI-powered applications using C# and modern DevOps practices, with both local and cloud deployment options.

## 🎯 Workshop Overview

**Date**: September 8, 2025  
**Duration**: 9:00 AM - 6:00 PM  
**Level**: Intermediate  
**Prerequisites**: Basic C# knowledge, Git familiarity, Docker Desktop

## 📁 Repository Structure

```text
vsl25sdhol/
├── exercises/          # Step-by-step lab exercises (9 exercises)
├── helpers/           # Helper applications and reference implementations
└── solutions/         # Complete reference solutions with MCP integration
```

### Exercises Directory

The `exercises/` folder contains 9 progressive hands-on labs:

**Part 1: GitHub Foundations (Exercises 1-6)**

- Exercise 1: GitHub Repository Setup
- Exercise 2: GitHub Copilot Configuration
- Exercise 3: GitHub Models Exploration
- Exercise 4: Codespaces and Code Generation
- Exercise 5: GitHub Advanced Security
- Exercise 6: GitHub Actions CI Setup

**Part 2: AI Application Development (Exercises 7-8)**

- Exercise 7: .NET AI Templates
- Exercise 8: GitHub Actions Deployment Workflow

**Part 3: Advanced Integration (Exercise 9)**

- Exercise 9: MCP Integration Exploration

### Helpers Directory

The `helpers/` folder contains reference applications and utilities:

**Local Track (`helpers/local/`)**

- Complete Ollama-based chat application with optimized performance
- Native Ollama integration examples (avoiding Docker overhead)
- Performance comparison implementations

**Cloud Track (`helpers/cloud/`)**

- Azure deployment templates and scripts
- Cost optimization configurations
- Security hardening examples

### Solutions Directory

The `solutions/` folder contains complete, production-ready implementations:

**Local Solutions (`solutions/local/`)**

- **OChatQALO**: Full-featured AI chat with Ollama, Qdrant, and MCP integration
  - Complete RAG implementation
  - GitHub issue creation via MCP
  - Production-ready architecture

**Cloud Solutions (`solutions/cloud/`)**

- **AChatSA**: Azure-hosted AI chat with automatic provisioning
  - Azure OpenAI integration
  - Azure AI Search for vector storage
  - MCP GitHub integration
  - Container Apps deployment

## 🚀 Quick Start

### Prerequisites Checklist

- [ ] **IDE**: Visual Studio 2022 or VS Code
- [ ] **Runtime**: .NET 9.0 SDK
- [ ] **Containerization**: Docker Desktop (latest)
- [ ] **Source Control**: Git and GitHub CLI
- [ ] **GitHub Account**: With Copilot access (for exercises 2-6)

### Getting Started

1. **Clone this repository**:

   ```bash
   git clone https://github.com/brianrandell/vsl25sdhol.git
   cd vsl25sdhol
   ```

2. **Navigate to exercises**:

   ```bash
   cd exercises
   ```

3. **Start with Exercise 1**:
   Open `01-github-repository-setup.md` and follow the instructions

## 🛤️ Learning Paths

### Track A: Self-Hosted AI (Local Development)

Perfect for organizations requiring on-premises deployment or data sovereignty:

- Uses Ollama for local LLM hosting
- Qdrant vector database for RAG
- No cloud dependencies
- Full control over data and models

### Track B: Cloud AI (Azure Deployment)

Ideal for scalable production deployments:

- Azure OpenAI for managed LLMs
- Azure AI Search for vector storage
- Container Apps for hosting
- Automatic scaling and monitoring

## 💻 Technology Stack

### Core Technologies

- **.NET 9.0** - Latest framework features
- **C# 13** - Modern language capabilities
- **.NET Aspire** - Cloud-native orchestration
- **ASP.NET Core** - Web application framework
- **Blazor Server** - Interactive UI components

### AI Technologies

- **Microsoft.Extensions.AI** - Unified AI abstractions
- **Ollama** - Local LLM hosting (Track A)
- **Azure OpenAI** - Cloud AI services (Track B)
- **Model Context Protocol (MCP)** - Tool integration

### DevOps Tools

- **GitHub Copilot** - AI-powered development
- **GitHub Codespaces** - Cloud development environment
- **GitHub Actions** - CI/CD automation
- **GitHub Advanced Security** - Security scanning

## 🔧 Development Commands

### Building Solutions

```bash
# Build a solution
dotnet build solutions/local/OChatQALO.sln
dotnet build solutions/cloud/AChatSA.sln

# Run with .NET Aspire (use AppHost project)
dotnet run --project solutions/local/OChatQALO/OChatQALO.AppHost/OChatQALO.AppHost.csproj
dotnet run --project solutions/cloud/AChatSA/AChatSA.AppHost/AChatSA.AppHost.csproj
```

### Testing

```bash
# Run tests
dotnet test solutions/local/OChatQALO.sln

# Format code
dotnet format

# Lint markdown files
markdownlint-cli2 exercises/*.md
```

## 🔒 Security Considerations

⚠️ **IMPORTANT**: Azure Container Apps are **publicly accessible by default**!

After deploying to Azure, you MUST:

1. Enable authentication immediately
2. Configure Microsoft Identity Provider
3. Use single-tenant authentication for corporate apps
4. Monitor access logs and set up alerts

See Exercise 8 for detailed security configuration instructions.

## 📚 Documentation

- **Workshop Exercises**: Start with `/exercises/README.md`
- **Local Solutions**: See `/solutions/local/README.md`
- **Cloud Solutions**: See `/solutions/cloud/README.md`
- **Performance Tips**: Check `/helpers/local/` for optimization examples

## 🆘 Getting Help

### During the Workshop

- Raise your hand for instructor assistance
- Check exercise troubleshooting sections
- Reference complete solutions in `/solutions/`

### Common Issues

- **Docker Issues**: Ensure Docker Desktop is running with adequate resources
- **Certificate Issues**: Run `dotnet dev-certs https --trust`
- **Package Issues**: Clear NuGet cache with `dotnet nuget locals all --clear`

## 📖 Additional Resources

- [Microsoft Learn - .NET Aspire](https://learn.microsoft.com/dotnet/aspire)
- [Model Context Protocol](https://modelcontextprotocol.io)
- [GitHub Copilot Documentation](https://docs.github.com/copilot)
- [Azure Container Apps](https://learn.microsoft.com/azure/container-apps/)

## 👥 Workshop Information

**Instructor**: Brian A. Randell, MCW Technologies  
**Event**: Visual Studio Live! San Diego 2025  
**Repository**: <https://github.com/brianrandell/vsl25sdhol>

## 📄 License

This repository is licensed under the [GNU Affero General Public License v3.0](LICENSE).

**License Scope**:

- ✅ Applies to the workshop exercises in `/exercises/`
- ✅ Applies to the reference solutions in `/solutions/`
- ❌ Does not apply to Microsoft-provided code, templates, or libraries
- ❌ Does not apply to third-party dependencies referenced via NuGet

The AGPL v3 ensures that any modifications to the workshop materials remain open source. Microsoft code and libraries retain their original licenses.

---

Ready to build AI-powered applications? Let's get started! 🚀
