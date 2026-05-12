import json
from graphify.build import build_from_json
from graphify.cluster import score_all
from graphify.analyze import god_nodes, surprising_connections, suggest_questions
from graphify.report import generate
from pathlib import Path

extraction = json.loads(Path('graphify-out/.graphify_extract.json').read_text())
detection  = json.loads(Path('graphify-out/.graphify_detect.json').read_text())
analysis   = json.loads(Path('graphify-out/.graphify_analysis.json').read_text())

G = build_from_json(extraction)
communities = {int(k): v for k, v in analysis['communities'].items()}
cohesion = {int(k): v for k, v in analysis['cohesion'].items()}
tokens = {'input': extraction.get('input_tokens', 0), 'output': extraction.get('output_tokens', 0)}

labels = {
    0: "Solution Architecture",
    1: "Use Cases & Workflows",
    2: "Brand Identity & Favicon",
    3: "Weather API Controller",
    4: "Reconnect Modal Logic",
    5: "App Root Component",
    6: "Routes Component",
    7: "_Imports Component",
    8: "NavMenu Component",
    9: "ReconnectModal Component",
    10: "Embedded Attribute",
    11: "Validation Attributes",
    12: "WeatherForecast Model",
    13: "Application AssemblyInfo",
    14: "Application GlobalUsings",
    15: "Domain AssemblyInfo",
    16: "Domain GlobalUsings",
    17: "Infrastructure AssemblyInfo",
    18: "Infrastructure GlobalUsings",
    19: "Web Program Entry",
    20: "Web AssemblyInfo",
    21: "Web GlobalUsings",
    22: "MainLayout Component",
    23: "Counter Page",
    24: "Error Page",
    25: "Home Page",
    26: "NotFound Page",
    27: "Weather Page",
    28: "WebApi Program Entry",
    29: "WebApi AssemblyInfo",
    30: "WebApi GlobalUsings",
}

questions = suggest_questions(G, communities, labels)

report = generate(G, communities, cohesion, labels, analysis['gods'], analysis['surprises'], detection, tokens, r'E:\Documentos\Proyectos\FinanKore', suggested_questions=questions)
Path('graphify-out/GRAPH_REPORT.md').write_text(report, encoding='utf-8')
Path('graphify-out/.graphify_labels.json').write_text(json.dumps({str(k): v for k, v in labels.items()}), encoding='utf-8')
print('Report updated with community labels')