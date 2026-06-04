import json
from pathlib import Path
detection = json.loads(Path(r'E:\Documentos\Proyectos\FinanKore\graphify-out\cost.json').read_text(encoding='utf-8'))
print('Cost file present, runs:', len(detection.get('runs',[])))
