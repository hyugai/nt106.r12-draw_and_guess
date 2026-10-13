## Directory tree

```text
draw_and_guess/
├── draw_and_guess.sln           # Solution: groups client and auth projects
├── src/
│   ├── client/                  # [APP] WinForms application (runs on Windows)
│   │   ├── forms/               # UI screens
│   │   │   ├── login_form.cs
│   │   │   ├── login_form.Designer.cs
│   │   │   ├── login_form.resx
│   │   │   ├── register_form.cs
│   │   │   ├── register_form.Designer.cs
│   │   │   ├── register_form.resx
│   │   │   ├── main_form.cs
│   │   │   ├── main_form.Designer.cs
│   │   │   └── main_form.resx
│   │   ├── program.cs          # Application entry point; load .env here
│   │   └── client.csproj        # References auth.csproj
│   └── auth/                    # [LIBRARY] Reusable authentication logic
│       ├── data/
│       │   ├── database.cs      # Creates SQL Server connections
│       │   └── user_dao.cs      # User queries: lookup, insert, update
│       ├── services/
│       │   ├── auth_service.cs  # Registration and login rules
│       │   └── password_hasher.cs # Hash and verify passwords
│       └── auth.csproj          # Class library, not an executable
├── database/
│   ├── migrations/
│   │   └── 001_create_users.sql # Users table definition
│   └── seeds/
│       └── 001_test_users.sql   # Optional test users
├── docker/
│   └── compose.yaml             # Runs SQL Server for development
├── .env                         # Local connection settings; DO NOT commit
├── .env.example                 # Example configuration without secrets
├── .gitignore
└── README.md
```
