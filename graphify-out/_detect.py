import json
from graphify.detect import detect
from pathlib import Path

result = detect(Path(r'E:\Documentos\Proyectos\FinanKore'))
Path('graphify-out/.graphify_detect.json').write_text(json.dumps(result), encoding='utf-8')
print(f"Detect: {result['total_files']} files, {result['total_words']} words")