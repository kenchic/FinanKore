import json
from graphify.extract import collect_files, extract
from pathlib import Path

detect = json.loads(Path(r'E:\Documentos\Proyectos\FinanKore\.graphify_detect.json').read_text(encoding='utf-8'))
code_files = []
for f in detect.get('files', {}).get('code', []):
    p = Path(f)
    if p.is_dir():
        code_files.extend(collect_files(p))
    else:
        code_files.append(p)

if code_files:
    result = extract(code_files)
    Path(r'E:\Documentos\Proyectos\FinanKore\.graphify_ast.json').write_text(json.dumps(result, indent=2), encoding='utf-8')
    print('AST:', len(result.get('nodes',[])), 'nodes,', len(result.get('edges',[])), 'edges')
else:
    Path(r'E:\Documentos\Proyectos\FinanKore\.graphify_ast.json').write_text(json.dumps({'nodes':[],'edges':[],'input_tokens':0,'output_tokens':0}), encoding='utf-8')
    print('No code files')
