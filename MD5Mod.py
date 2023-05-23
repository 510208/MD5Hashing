import hashlib
import sys

def calculate_hashes(file_path):
    md5_hash = ''
    sha256_hash = ''

    try:
        with open(file_path, 'rb') as file:
            data = file.read()
            md5_hash = hashlib.md5(data).hexdigest()
            sha256_hash = hashlib.sha256(data).hexdigest()
    except Exception as e:
        # 處理錯誤
        print('發生錯誤:', str(e))

    # 返回結果
    return file_path, md5_hash, sha256_hash


if __name__ == '__main__':
    file_path = sys.argv[1] if len(sys.argv) > 1 else ''
    result = calculate_hashes(file_path)

    for item in result:
        print(item)

