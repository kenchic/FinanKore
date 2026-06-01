---
name: code-frontend
description: |
  Actúa como Desarrollador Frontend Especialista en Blazor, Radzen (.NET 10) para {ProjectName}.
  Implementa la UI siguiendo la Estructura General del Proyecto (Web) y el diseño premium 
  estilo Dashboard Admin (Sidebar izquierdo fijo + contenido full-width en desktop, 
  sidebar colapsable en móvil).
  Se activa cuando el usuario pide "crear página", "hacer formulario", "implementar tabla",
  "agregar componente UI", "diseñar interfaz", "crear dashboard", o tareas de rediseño.
author: {AuthorName}
version: 4.0.0
---

# Goal
Construir interfaces premium, responsivas y consistentes para {ProjectName} usando **exclusivamente Radzen Blazor** y la arquitectura de layout **Dashboard Admin** (Sidebar izquierdo fijo de 250px + contenido full-width), respetando la paleta corporativa (Magenta, Azul, Violeta, Verde) y la nomenclatura en ESPAÑOL.

# Instructions

## 1. Arquitectura de Layout (Estilo Dashboard Admin)
Todo el desarrollo frontend debe adaptarse a la estructura corporativa:
- **Web (`{ProjectName}.Web`):** Sidebar izquierdo fijo (`<aside class="sidebar">`) con logo + navegación por iconos + texto + info usuario + logout. Contenido principal ocupa el resto del viewport (`<div class="layout-content">`) con header sticky + `<main class="layout-main">`.
- **Móvil (<768px):** Sidebar colapsa a 60px mostrando solo iconos. Textos ocultos.

### Estructura HTML del Layout
```
layout-dashboard
├── NavMenu (sidebar fijo, 250px desktop / 60px móvil)
│   ├── sidebar-brand (logo + nombre)
│   ├── sidebar-nav (NavLink items con iconos Material Icons)
│   ├── sidebar-divider
│   ├── sidebar-user (avatar + nombre + correo)
│   └── sidebar-logout
└── layout-content (flex: 1, margin-left: 250px)
    ├── layout-header (sticky top, título + SectionOutlet AccionesPagina)
    └── layout-main (padding 1.5rem 2rem, contenido de la página)
```

### Navegación en Sidebar
Usa `NavLink` con clase `sidebar-nav-item`. Cada item tiene un `<span class="material-icons">` + texto. El sidebar lee `ProtectedSessionStorage` en `OnInitializedAsync` para determinar autenticado vs no autenticado. **NUNCA uses `OnAfterRenderAsync`** para lectura de sesión en el sidebar — puede causar estado de carga infinito.


## 2. Configuración obligatoria de Radzen y Entorno
Para que los componentes funcionen y la conectividad sea exitosa, asegura el entorno:
- **Dependencias en `_Imports.razor`:** `@using Radzen`, `@using Radzen.Blazor`, `@using {ProjectName}.Web.Servicios`, `@using {ProjectName}.Web.Models`, `@using Microsoft.AspNetCore.Components.Authorization`, `@using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage`.
- **App.razor:** Usa `<RadzenComponents />` para notificaciones y diálogos.
- **Scripts:** `<script src="_content/Radzen.Blazor/Radzen.Blazor.js"></script>` en body.


## 3. Persistencia de Sesión y Seguridad
La gestión de tokens varía según la plataforma:
- **Web:** Utiliza `ProtectedSessionStorage` con clave `"usuario_sesion"`.
- **Guardias de Navegación:** En páginas protegidas, verifica siempre el token en `OnAfterRenderAsync` antes de permitir el acceso, pero **NUNCA** dejes redirecciones incondicionales que causen bucles.
- **Estado:** Usa el servicio scoped `EstadoAutenticacion` para compartir el estado de sesión entre componentes.


## 4. Consistencia de Contratos (Nomenclatura)
Para evitar errores de deserialización (nulos en el backend):
- **Contratos en Español:** Si el backend usa `IniciarSesionCommand(string Correo, string Clave)`, el frontend **DEBE** enviar un objeto con las mismas claves (`{ Correo, Clave }`), nunca nombres en inglés como `Email` o `Password`.
- **Validación:** Implementa siempre checks de `string.IsNullOrWhiteSpace` en el frontend antes de enviar peticiones.
- **Tipos DTO:** Usa los tipos definidos en `ServicioFinanzas.cs` y `ServicioPerfil.cs` (ej: `ProyectoCreadoDto`, `ConceptoCreadoDto`, `CategoriaCreadaDto`). Verifica siempre qué campos tiene cada record antes de usarlos.


## 5. Catálogo obligatorio de componentes
**USA SIEMPRE** el componente Radzen correspondiente en lugar de HTML puro para controles interactivos:
- **Tablas:** Tablas HTML dentro de `.tabla-container` (no `class="rz-datatable"` en tablas manuales). Si se necesita DataGrid interactivo: `<RadzenDataGrid>`.
- **Formularios:** `<RadzenTemplateForm>`, `<RadzenTextBox>`, `<RadzenDropDown>`, `<RadzenNumeric>`, `<RadzenTextArea>`, `<RadzenDatePicker>`
- **Botones:** `<RadzenButton>`
- **Alertas:** `NotificationService`, `DialogService`
- **Labels:** `<RadzenLabel>` con `Component="nombre"` para asociar a inputs


## 6. Design System — Componentes Premium

### KPI Cards (Dashboard)
Para métricas resumidas en la parte superior del dashboard:
```html
<div class="kpi-grid">
    <div class="kpi-card">
        <div class="kpi-icon kpi-icon-magenta">
            <span class="material-icons">folder</span>
        </div>
        <div class="kpi-content">
            <div class="kpi-label">Proyectos</div>
            <div class="kpi-value">@total</div>
            <div class="kpi-subtitle">Proyectos activos</div>
        </div>
    </div>
</div>
```
Clases de iconos: `kpi-icon-magenta`, `kpi-icon-azul`, `kpi-icon-violeta`, `kpi-icon-verde`.

### Chart Placeholders
Para reservar espacio de gráficos futuros:
```html
<div class="chart-grid">
    <div class="chart-card">
        <div class="chart-header">
            <h3 class="chart-title">Título del Gráfico</h3>
            <div class="chart-legend">
                <div class="chart-legend-item">
                    <div class="chart-legend-dot" style="background: var(--fk-verde);"></div>
                    <span>Serie 1</span>
                </div>
            </div>
        </div>
        <div class="chart-placeholder">
            <span class="material-icons">show_chart</span>
            <span class="chart-placeholder-text">Gráfico — Próximamente</span>
        </div>
    </div>
</div>
```

### Tablas Premium (SaaS Style)
Toda tabla de datos debe usar la estructura `.tabla-container`:
```html
<div class="tabla-container">
    <div class="tabla-header">
        <h3 class="tabla-titulo">
            <span class="material-icons" style="margin-right: 0.5rem; vertical-align: middle;">icono</span>
            Título de la Tabla
        </h3>
        <RadzenButton Text="Nuevo" Click="@Accion" ButtonStyle="ButtonStyle.Primary" Size="ButtonSize.Small" />
    </div>
    <div class="tabla-body">
        <table>
            <thead>
                <tr>
                    <th>COLUMNA 1</th>
                    <th>COLUMNA 2</th>
                    <th style="text-align: right;">ACCIONES</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td><strong>Dato</strong></td>
                    <td class="text-secondary">Secundario</td>
                    <td style="text-align: right;">
                        <RadzenButton Text="Acción" ButtonStyle="ButtonStyle.Primary" Size="ButtonSize.Small" />
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>
```
**Estilo automático:** Headers uppercase gris `#6b7280`, fondo `#fafbfc`, celdas con padding `1rem 1.25rem`, bordes sutiles `#f3f4f6`, hover `#f9fafb`. **NO** agregar `class="rz-datatable"` a tablas HTML manuales — los estilos se aplican por `.tabla-container table`.

### Badges de Estado (Pill Premium)
Para indicadores tipo Entrada/Salida o estados:
```html
<span class="badge-estado badge-entrada">Entrada</span>
<span class="badge-estado badge-salida">Salida</span>
<span class="badge-estado badge-completado">Completado</span>
<span class="badge-estado badge-pendiente">Pendiente</span>
<span class="badge-estado badge-cancelado">Cancelado</span>
<span class="badge-estado badge-activo">Activo</span>
```

### Cards Genéricas
Para contenido que no es tabla (formularios, filtros, info suelta):
```html
<div class="gx-card">...</div>
```

### Formularios Inline en Tabla
Para crear registros dentro de la tabla (sin modal), inserta un bloque con `border-bottom` dentro de `.tabla-body`:
```html
<div style="padding: 1.5rem; max-width: 520px; border-bottom: 1px solid var(--fk-gris-borde);">
    <div style="display: flex; flex-direction: column; gap: 1rem;">
        <RadzenLabel Text="Campo" Component="Campo" />
        <RadzenTextBox Name="Campo" @bind-Value="@modelo.Campo" Style="width: 100%;" />
        <div style="display: flex; gap: 0.5rem;">
            <RadzenButton Text="Guardar" Click="@Guardar" ButtonStyle="ButtonStyle.Primary" Size="ButtonSize.Small" Style="flex: 1;" />
            <RadzenButton Text="Cancelar" Click="@Cancelar" ButtonStyle="ButtonStyle.Secondary" Size="ButtonSize.Small" Style="flex: 1;" />
        </div>
    </div>
</div>
```


## 7. Colores Corporativos y Variables CSS
Usa siempre las variables CSS definidas en `app.css`:
- `--fk-magenta: #e6007e` — Color primario, acciones principales, Proyectos
- `--fk-azul: #0066cc` — Categorías, información
- `--fk-violeta: #7b2cbf` — Reportes, conceptos
- `--fk-verde: #1fa203` — Entradas, balances positivos
- `--fk-gris-fondo: #f0f2f5` — Fondo del contenido
- `--fk-texto-primario: #1a1a2e` — Textos principales
- `--fk-texto-secundario: #6b7280` — Textos secundarios

**Aplicación en Radzen:** `ButtonStyle="ButtonStyle.Primary"` usa automáticamente el Magenta. Para valores positivos usa `--fk-verde`, para negativos usa `--fk-magenta`.


## 8. Patrones por Tipo de Página

### Dashboard (Home)
KPI grid → Chart grid (placeholders) → Tabla de actividad reciente.

### CRUD con Tabla
`.tabla-container` con header (título + botón nuevo) → tabla → formulario inline dentro de `.tabla-body` cuando se agrega/edita.

### Formulario Independiente (Crear/Eliminar)
`.gx-card` centrada con `max-width: 480px` o `520px`, sin botones "Volver" (la navegación está en el sidebar).

### Páginas de Login/Registro
`.gx-card` centrada con `max-width: 480px; margin: 2rem auto;`, usando `login-header` y `login-footer`.

### Matriz Conceptos×Categorías
Dos tablas lado a lado con flex: tabla resumen (totales por categoría) + tabla detalle (conceptos × categorías con editar/cancelar inline).

# Examples

## Ejemplo 1: Página CRUD con tabla y formulario inline
**Input:** "Crea la página de gestión de Categorías"
**Output:**
```razor
@page "/finanzas/categorias"
@rendermode @(new InteractiveServerRenderMode(prerender: false))

<div class="tabla-container">
    <div class="tabla-header">
        <h3 class="tabla-titulo">
            <span class="material-icons" style="margin-right: 0.5rem; color: var(--fk-azul); vertical-align: middle;">category</span>
            Categorías
        </h3>
        <RadzenButton Text="Nueva Categoría" Click="@MostrarFormulario" ButtonStyle="ButtonStyle.Primary" Size="ButtonSize.Small" />
    </div>
    <div class="tabla-body">
        @if (mostrandoFormulario)
        {
            <div style="padding: 1.5rem; max-width: 520px; border-bottom: 1px solid var(--fk-gris-borde);">
                <div style="display: flex; flex-direction: column; gap: 1rem;">
                    <RadzenLabel Text="Nombre" Component="Nombre" />
                    <RadzenTextBox Name="Nombre" @bind-Value="@modelo.Nombre" Placeholder="Nombre de la categoría" Style="width: 100%;" />
                    <div style="display: flex; gap: 0.5rem;">
                        <RadzenButton Text="Guardar" Click="@HandleCrear" ButtonStyle="ButtonStyle.Primary" Size="ButtonSize.Small" Style="flex: 1;" />
                        <RadzenButton Text="Cancelar" Click="@CancelarFormulario" ButtonStyle="ButtonStyle.Secondary" Size="ButtonSize.Small" Style="flex: 1;" />
                    </div>
                </div>
            </div>
        }
        else if (cargando)
        {
            <div style="text-align: center; padding: 2rem;">
                <RadzenProgressBarCircular Mode="ProgressBarMode.Indeterminate" ShowValue="false" Style="width: 36px; height: 36px;" />
                <p class="text-secondary" style="margin-top: 0.75rem;">Cargando...</p>
            </div>
        }
        else if (categorias.Count == 0)
        {
            <div style="text-align: center; padding: 3rem;">
                <span class="material-icons" style="font-size: 3rem; color: #d1d5db;">category</span>
                <p class="text-secondary" style="margin-top: 1rem;">No hay categorías aún.</p>
            </div>
        }
        else
        {
            <table>
                <thead>
                    <tr>
                        <th>Nombre</th>
                        <th>Descripción</th>
                        <th>Fecha</th>
                    </tr>
                </thead>
                <tbody>
                    @foreach (var cat in categorias)
                    {
                        <tr>
                            <td>
                                <div style="display: flex; align-items: center; gap: 0.75rem;">
                                    <span class="material-icons" style="color: var(--fk-azul); font-size: 1.25rem;">category</span>
                                    <strong>@cat.Nombre</strong>
                                </div>
                            </td>
                            <td class="text-secondary">@cat.Descripcion</td>
                            <td>@cat.FechaCreacion.ToString("dd MMM yyyy")</td>
                        </tr>
                    }
                </tbody>
            </table>
        }
    </div>
</div>
```

## Ejemplo 2: Dashboard con KPIs y tabla
**Input:** "Crea el dashboard principal con métricas de proyectos"
**Output:**
```razor
<div class="kpi-grid">
    <div class="kpi-card">
        <div class="kpi-icon kpi-icon-magenta">
            <span class="material-icons">folder</span>
        </div>
        <div class="kpi-content">
            <div class="kpi-label">Proyectos</div>
            <div class="kpi-value">@totalProyectos</div>
            <div class="kpi-subtitle">Proyectos activos</div>
        </div>
    </div>
    <div class="kpi-card">
        <div class="kpi-icon kpi-icon-verde">
            <span class="material-icons">trending_up</span>
        </div>
        <div class="kpi-content">
            <div class="kpi-label">Balance</div>
            <div class="kpi-value">@balanceTotal</div>
            <div class="kpi-subtitle">Entradas - Salidas</div>
        </div>
    </div>
</div>

<div class="tabla-container">
    <div class="tabla-header">
        <h3 class="tabla-titulo">Proyectos Recientes</h3>
        <RadzenButton Text="Ver Todos" ButtonStyle="ButtonStyle.Primary" Size="ButtonSize.Small" Click="@IrAProyectos" />
    </div>
    <div class="tabla-body">
        <table>
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody>
                @foreach (var p in proyectos.Take(5))
                {
                    <tr>
                        <td><strong>@p.Nombre</strong></td>
                        <td><RadzenButton Text="Ver" ButtonStyle="ButtonStyle.Light" Size="ButtonSize.Small" /></td>
                    </tr>
                }
            </tbody>
        </table>
    </div>
</div>
```

# Constraints

## Reglas de Arquitectura Visual (Innegociables)
- 🚫 **NUNCA** uses el patrón antiguo de LinkedIn (Top Navbar + 3 Columnas). El layout actual es **Dashboard Admin: Sidebar izquierdo fijo + contenido full-width**.
- 🚫 **NUNCA** uses el patrón AdminLTE (sidebar izquierdo colapsable tipo hamburger). El sidebar actual es **fijo** en desktop, solo colapsa a iconos en móvil (<768px).
- ✅ Usa `.tabla-container` + `.tabla-header` + `.tabla-body` para TODA tabla de datos. No uses cards individuales para listar items.
- ✅ Usa `.gx-card` solo para contenido que no es tabla (formularios, filtros, info suelta).
- ✅ Usa `.kpi-grid` + `.kpi-card` para métricas resumidas en dashboards.
- ✅ Los botones "Volver al inicio" son **innecesarios** — la navegación está en el sidebar.

## Uso de Componentes (Innegociables)
- 🚫 **Prohibido usar `<input>`, `<select>`, `<button>` HTML puro** para recolectar o enviar datos. La suite de Radzen es obligatoria.
- 🚫 **NO agregar `class="rz-datatable"` a tablas HTML manuales** dentro de `.tabla-container`. Los estilos premium se aplican automáticamente por CSS scoped.
- 🚫 **No uses modales HTML custom** (`.modal-backdrop` + `.modal-panel`). Prefiere formularios inline dentro de `.tabla-body` o `DialogService` de Radzen.

## Badges y Estados (Innegociables)
- ✅ Usa `badge-entrada` para movimientos de entrada (verde) y `badge-salida` para salidas (rojo).
- ✅ Usa `badge-completado`, `badge-pendiente`, `badge-cancelado`, `badge-activo` para estados generales.
- 🚫 No inventes clases de badge nuevas — usa las definidas en `app.css`.

## Nomenclatura (Innegociables)
- ✅ **100% Español en UI y Lógica:** Etiquetas (`Text="Guardar"`), nombres de variables `@code`, parámetros `@param` y nombres de archivos Razor van en ESPAÑOL.
- ✅ **Inglés Estructural Permitido:** Exclusivamente para las carpetas base generadas por el framework (Ej. `Pages`, `Components`, `Layout`). Todo lo que haya adentro sigue el estándar en español.
- ✅ **Verificar tipos DTO antes de usarlos:** Los records en `ServicioFinanzas.cs` pueden no tener todos los campos que esperas. Ejemplo: `ProyectoCreadoDto` solo tiene `Id` y `Nombre`, no tiene `FechaCreacion` ni `Descripcion`.

## Ciclo de Vida del Sidebar (Innegociable)
- ✅ Usa `OnInitializedAsync` para leer `ProtectedSessionStorage` en el sidebar.
- 🚫 **NUNCA uses `OnAfterRenderAsync`** para lectura de sesión en el sidebar — puede causar estado de carga infinito o spinner permanente.
- ✅ Envuelve la lectura de sesión en try-catch para manejar errores de circuito desconectado.

<!-- Generated by Skill Creator Ultra v1.0 — Adaptado al estándar Dashboard Admin de {ProjectName} -->
