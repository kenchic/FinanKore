import json
from pathlib import Path
analysis = json.loads(Path(r'E:\Documentos\Proyectos\FinanKore\.graphify_analysis.json').read_text(encoding='utf-8'))
communities = analysis['communities']
cohesion = analysis['cohesion']
# Show top communities by size
for cid in sorted(communities.keys(), key=lambda k: len(communities[k]), reverse=True)[:15]:
    nodes = communities[cid]
    coh = cohesion.get(cid, 'N/A')
    labels_preview = [n if isinstance(nodes[0], str) else str(n) for n in nodes[:5]]
    print(f'Community {cid} ({len(nodes)} nodes, cohesion={coh}): {labels_preview}')
