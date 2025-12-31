import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CatsService {

  constructor(private http: HttpClient) {}

  getBreeds() {
    return this.http.get<any[]>('https://api.thecatapi.com/v1/breeds');
  }

  getImagesByBreed(breedId: string) {
    return this.http.get<any[]>(
      `https://api.thecatapi.com/v1/images/search?breed_ids=${breedId}&limit=5`
    );
  }
}
