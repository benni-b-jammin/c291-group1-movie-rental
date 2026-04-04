$server = "localhost"
$database = "RentalDB"
$username = "superuser"
$password = "dbaccess"

$rootCreateFile = ".\RentalDB_create.sql"

$files = @(
    ".\insert\00_clear.sql",
    ".\insert\01_employee.sql",
    ".\insert\02_customer.sql",
    ".\insert\03_movie.sql",
    ".\insert\04_actor.sql",
    ".\insert\05_ma_relation.sql",
    ".\insert\06_rental.sql",
    ".\insert\07_rating.sql",
    ".\insert\08_queue.sql"
)

Write-Host "Running $rootCreateFile ..."
sqlcmd -S $server -d $database -U $username -P $password -C -i $rootCreateFile

if ($LASTEXITCODE -ne 0) {
    Write-Host "Error while running $rootCreateFile"
    exit $LASTEXITCODE
}

foreach ($file in $files) {
    Write-Host "Running $file ..."
    sqlcmd -S $server -d $database -U $username -P $password -C -i $file

    if ($LASTEXITCODE -ne 0) {
        Write-Host "Error while running $file"
        exit $LASTEXITCODE
    }
}

Write-Host "Create script and all insert files completed successfully."