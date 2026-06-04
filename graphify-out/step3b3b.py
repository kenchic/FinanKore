import json
from graphify.cache import save_semantic_cache
from pathlib import Path

new = json.loads(Path(r'E:\Documentos\Proyectos\FinanKore\.graphify_semantic_new.json').read_text(encoding='utf-8'))
saved = save_semantic_cache(new.get('nodes', []), new.get('edges', []), new.get('hyperedges', []))
print(f'Cached {saved} files')
