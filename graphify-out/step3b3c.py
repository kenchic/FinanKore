import json
from pathlib import Path

cached_path = Path(r'E:\Documentos\Proyectos\FinanKore\.graphify_cached.json')
new_path = Path(r'E:\Documentos\Proyectos\FinanKore\.graphify_semantic_new.json')

cached = json.loads(cached_path.read_text(encoding='utf-8')) if cached_path.exists() else {'nodes':[],'edges':[],'hyperedges':[]}
new = json.loads(new_path.read_text(encoding='utf-8')) if new_path.exists() else {'nodes':[],'edges':[],'hyperedges':[]}

all_nodes = cached['nodes'] + new.get('nodes', [])
all_edges = cached['edges'] + new.get('edges', [])
all_hyperedges = cached.get('hyperedges', []) + new.get('hyperedges', [])
seen = set()
deduped = []
for n in all_nodes:
    if n['id'] not in seen:
        seen.add(n['id'])
        deduped.append(n)

merged = {
    'nodes': deduped,
    'edges': all_edges,
    'hyperedges': all_hyperedges,
    'input_tokens': new.get('input_tokens', 0),
    'output_tokens': new.get('output_tokens', 0),
}
Path(r'E:\Documentos\Proyectos\FinanKore\.graphify_semantic.json').write_text(json.dumps(merged, indent=2), encoding='utf-8')
cached_nodes = len(cached.get('nodes',[]))
new_nodes = len(new.get('nodes',[]))
print(f'Extraction complete - {len(deduped)} nodes, {len(all_edges)} edges ({cached_nodes} from cache, {new_nodes} new)')
