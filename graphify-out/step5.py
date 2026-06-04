import sys, json
from graphify.build import build_from_json
from graphify.cluster import score_all
from graphify.analyze import god_nodes, surprising_connections, suggest_questions
from graphify.report import generate
from pathlib import Path

extraction = json.loads(Path(r'E:\Documentos\Proyectos\FinanKore\.graphify_extract.json').read_text(encoding='utf-8'))
detection  = json.loads(Path(r'E:\Documentos\Proyectos\FinanKore\.graphify_detect.json').read_text(encoding='utf-8'))
analysis   = json.loads(Path(r'E:\Documentos\Proyectos\FinanKore\.graphify_analysis.json').read_text(encoding='utf-8'))

G = build_from_json(extraction)
communities = {int(k): v for k, v in analysis['communities'].items()}
cohesion = {int(k): v for k, v in analysis['cohesion'].items()}
tokens = {'input': extraction.get('input_tokens', 0), 'output': extraction.get('output_tokens', 0)}

labels = {
    0: 'Infraestructura Persistencia',
    1: 'Dominio Base Entidades',
    2: 'Modelos Web y DTOs',
    3: 'Manejadores Aplicacion',
    4: 'Autenticacion y Perfil',
    5: 'Scripts SQL y Tablas',
    6: 'Entidades Dominio Finanzas',
    7: 'Consultas Proyectos y Reportes',
    8: 'Paginas Razor Reportes',
    9: 'Servicios Web HTTP',
    10: 'Configuraciones EF Core',
    11: 'Pagina Home Dashboard',
    12: 'Comandos y DTOs Finanzas',
    13: 'Caso Uso Reportes',
    14: 'Interfaces Repositorio',
    15: 'Endpoints API Finanzas',
    16: 'Endpoints API Perfil',
    17: 'Endpoints API Reportes',
    18: 'Objetos Valor Dominio',
}

questions = suggest_questions(G, communities, labels)

report = generate(G, communities, cohesion, labels, analysis['gods'], analysis['surprises'], detection, tokens, r'E:\Documentos\Proyectos\FinanKore', suggested_questions=questions)
Path(r'E:\Documentos\Proyectos\FinanKore\graphify-out\GRAPH_REPORT.md').write_text(report, encoding='utf-8')
Path(r'E:\Documentos\Proyectos\FinanKore\.graphify_labels.json').write_text(json.dumps({str(k): v for k, v in labels.items()}), encoding='utf-8')
print('Report updated with community labels')
